/*
Project Name: PowerSlider
Author: Matthew Bunch
Date: 1/27/21
Description: PowerSlider is a nifty tool that can help users create users create meaningful slides
by specifying keywords found in the title and selected bolded subtext.
Users can query something like Japanese + Gardens and return with beautiful images of Japanese Gardens.
    This program does not use Google Images but instead searches a public domain site called free-images.com
for the images. Keep in note that this is due to the sheer complexity of Google's html code, which is a real
mess to deal with. A third party API would be more ideal for dealing with Google's mess of code to return
image sources. I do seriously apologize for this minor inconvenience. You could modify this code to work
with Google Images, but I think its a pretty time consuming effort. 
    There is no limit to the number of pictures you can select for download, although I recommend a maximum
of four images for a new slide. At start the form does not display any images, but this is changed as soon
as the user selects the Search Images button. The images displayed for selection are not downloaded but
are instead streamed image byte information to the form for the user to preview before selecting for download.
The images are actually downloaded and placed in the Presentation as soon as the user selects the
Create My Slide button. The Select Image button sets the desired image into a queued list of images for
download.
 * This version uses .NET Framework 4.5
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace PowerSlider
{
    public partial class PowerSlider_MainForm : Form
    {
        public PowerSlider_MainForm()
        {
            InitializeComponent();
        }

        List<string> keywordList = new List<string>();
        List<string> urlList = new List<string>();
        List<string> presentationImages = new List<string>();

        int index = 0;
        int indexMax = 0;

        private void createSlideBtn_Click(object sender, EventArgs e)
        {
            String title = titleBox.Text;
            String content = contentBox.Text;

            PowerPoint.Application pptApp = new PowerPoint.Application();

            PowerPoint.Slides slides;
            PowerPoint._Slide slide;
            PowerPoint.TextRange objText;

            PowerPoint.Presentation myPres = pptApp.Presentations.Add(Office.MsoTriState.msoTrue);
            PowerPoint.CustomLayout customLayout = myPres.SlideMaster.CustomLayouts[PowerPoint.PpSlideLayout.ppLayoutText];

            slides = myPres.Slides;
            slide = slides.AddSlide(1, customLayout);

            //Add title
            objText = slide.Shapes[1].TextFrame.TextRange;
            objText.Text = title;

            //Add content
            objText = slide.Shapes[2].TextFrame.TextRange;
            objText.Text = content;

            //We need a temporary home for our image files, so lets create one within C:\tmp
            string subDir = @"C:\tmp\newPPT";
            //Create a new subdirectory (folder) called newPPT
            if (!Directory.Exists(subDir))
            {
                Directory.CreateDirectory(subDir);
            }

            //Download our selected files to our created folder
            foreach (string image in presentationImages)
            {
                WebClient webClient = new WebClient();
                string file = subDir + "\\" + Path.GetFileName(image);
                webClient.DownloadFile(image, file); //download image from url and save in file
            }

            int pictureIndex = 0;

            //Grabs our downloaded files and loads them into the slide
            string[] fileNames = Directory.GetFiles(subDir);
            foreach (string file in fileNames)
            {
                int left = 20 + 200 * pictureIndex;
                int top = 200; //+ 50*pictureIndex;
                int width = 200;
                int height = 200;
                slide.Shapes.AddPicture(file, Office.MsoTriState.msoFalse, Office.MsoTriState.msoCTrue, left, top, width, height);
                pictureIndex++;
            }

            //Cleanup Files and Folder
            if (Directory.Exists(subDir))
            {
                DirectoryInfo di = new DirectoryInfo(subDir);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
            }
            Directory.Delete(subDir);
        }

        private void searchImagesBtn_Click(object sender, EventArgs e)
        {
            //get user input and parse string
            String titleText = titleBox.Text;
            ParseString(titleText); //title is parsed and keywords added to list

            //google query string
            String startStr = "https://free-images.com/search/?q=";
            //String endStr = "&tbm=isch";
            String midStr = "";

            String last = keywordList.Last();

            //build keyword section of google query string
            foreach (string keyword in keywordList)
            {
                if (keyword.Equals(last))
                {
                    midStr = midStr + keyword;
                }
                else midStr = midStr + keyword + "+";
            }

            //google query string is complete
            String searchStr = startStr + midStr;

            //need to retrieve urls for the first nine image results
            string htmlCode = GetHTMLCode(searchStr); //grab html code
            List<string> urls = GetUrls(htmlCode); //feed html code and get the urls

            urlList = urls; //copy urls to global variable
            indexMax = (urlList.Count > 0 ? urlList.Count - 1 : 0);

            //stream image to pictureBox1
            try
            {
                byte[] image = GetImage(urls[0]);
                using (var ms = new MemoryStream(image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No image found.");
            }
        }

        //This function returns the htmlcode of the webpage
        private string GetHTMLCode(string url)
        {
            string data = "";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return "";
                using (var sr = new StreamReader(dataStream))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }

        //This function takes the htmlcode and uses a regular expression to find the src attribute
        //within the img html element to find each complete url associated with an image
        private List<string> GetUrls(string html)
        {
            var urls = new List<string>();
            string urlPrefix = "https://free-images.com";

            string search = "<img.+?src=[\"'](.+?)[\"'].*?>";
            MatchCollection matches = Regex.Matches(html, search);

            foreach (Match match in matches)
            {
                urls.Add(urlPrefix + match.Groups[1].Value);
            }
            return urls;
        }

        //This function takes a request for an image and reads back the image information
        private byte[] GetImage(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                if (dataStream == null)
                    return null;
                using (var sr = new BinaryReader(dataStream))
                {
                    byte[] bytes = sr.ReadBytes(100000000);
                    return bytes;
                }
            }
        }

        //This function simply splits the text string by single spaces and adds the words to the keyword list
        public void ParseString(string str)
        {
            string text = str;
            string[] words = text.Split(' ');

            foreach (var word in words)
            {
                keywordList.Add(word);
            }
        }

        private void nxtImgBtn_Click(object sender, EventArgs e)
        {
            //Select next Image url and set pictureBox1.Image to index
            if (index < indexMax)
            {
                index++;
                byte[] image = GetImage(urlList[index]);
                using (var ms = new MemoryStream(image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void prevImgBtn_Click(object sender, EventArgs e)
        {
            //Select previous Image url and set pictureBox1.Image to index
            if (index > 0)
            {
                index--;
                byte[] image = GetImage(urlList[index]);
                using (var ms = new MemoryStream(image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private void setImgBtn_Click(object sender, EventArgs e)
        {
            presentationImages.Add(urlList[index]); //When user clicks, url is added to a selected list
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            contentBox.SelectionFont = new Font("Segoe UI", 9, FontStyle.Bold);
            keywordList.Add(contentBox.SelectedText); //A bolded word is added as a keyword to the list
        }

        //reset global variables and clear the textboxes and the picturebox
        private void resetBtn_Click(object sender, EventArgs e)
        {
            keywordList.Clear();
            urlList.Clear();
            presentationImages.Clear();
            index = 0;
            indexMax = 0;

            titleBox.Text = "";
            contentBox.Text = "";
            pictureBox1.Image = null;
        }
    }
}
