namespace PowerSlider
{
    partial class PowerSlider_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.contentBox = new System.Windows.Forms.RichTextBox();
            this.searchImagesBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.prevImgBtn = new System.Windows.Forms.Button();
            this.setImgBtn = new System.Windows.Forms.Button();
            this.nxtImgBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boldBtn = new System.Windows.Forms.Button();
            this.createSlideBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(306, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 193);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(72, 15);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(217, 20);
            this.titleBox.TabIndex = 1;
            this.titleBox.Text = "Enter Title";
            // 
            // contentBox
            // 
            this.contentBox.Location = new System.Drawing.Point(72, 61);
            this.contentBox.Name = "contentBox";
            this.contentBox.Size = new System.Drawing.Size(217, 141);
            this.contentBox.TabIndex = 2;
            this.contentBox.Text = "Enter Content";
            // 
            // searchImagesBtn
            // 
            this.searchImagesBtn.Location = new System.Drawing.Point(72, 237);
            this.searchImagesBtn.Name = "searchImagesBtn";
            this.searchImagesBtn.Size = new System.Drawing.Size(102, 23);
            this.searchImagesBtn.TabIndex = 3;
            this.searchImagesBtn.Text = "Search Images";
            this.searchImagesBtn.UseVisualStyleBackColor = true;
            this.searchImagesBtn.Click += new System.EventHandler(this.searchImagesBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(180, 208);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(109, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // prevImgBtn
            // 
            this.prevImgBtn.Location = new System.Drawing.Point(324, 237);
            this.prevImgBtn.Name = "prevImgBtn";
            this.prevImgBtn.Size = new System.Drawing.Size(76, 23);
            this.prevImgBtn.TabIndex = 5;
            this.prevImgBtn.Text = "Previous";
            this.prevImgBtn.UseVisualStyleBackColor = true;
            this.prevImgBtn.Click += new System.EventHandler(this.prevImgBtn_Click);
            // 
            // setImgBtn
            // 
            this.setImgBtn.Location = new System.Drawing.Point(405, 237);
            this.setImgBtn.Name = "setImgBtn";
            this.setImgBtn.Size = new System.Drawing.Size(84, 23);
            this.setImgBtn.TabIndex = 6;
            this.setImgBtn.Text = "Select Image";
            this.setImgBtn.UseVisualStyleBackColor = true;
            this.setImgBtn.Click += new System.EventHandler(this.setImgBtn_Click);
            // 
            // nxtImgBtn
            // 
            this.nxtImgBtn.Location = new System.Drawing.Point(494, 237);
            this.nxtImgBtn.Name = "nxtImgBtn";
            this.nxtImgBtn.Size = new System.Drawing.Size(89, 23);
            this.nxtImgBtn.TabIndex = 7;
            this.nxtImgBtn.Text = "Next";
            this.nxtImgBtn.UseVisualStyleBackColor = true;
            this.nxtImgBtn.Click += new System.EventHandler(this.nxtImgBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select an Image";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(39, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contents";
            // 
            // boldBtn
            // 
            this.boldBtn.Location = new System.Drawing.Point(72, 208);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(102, 23);
            this.boldBtn.TabIndex = 11;
            this.boldBtn.Text = "Bold Keyword";
            this.boldBtn.UseVisualStyleBackColor = true;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // createSlideBtn
            // 
            this.createSlideBtn.Location = new System.Drawing.Point(180, 237);
            this.createSlideBtn.Name = "createSlideBtn";
            this.createSlideBtn.Size = new System.Drawing.Size(109, 23);
            this.createSlideBtn.TabIndex = 12;
            this.createSlideBtn.Text = "Create My Slide";
            this.createSlideBtn.UseVisualStyleBackColor = true;
            this.createSlideBtn.Click += new System.EventHandler(this.createSlideBtn_Click);
            // 
            // PowerSlider_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 278);
            this.Controls.Add(this.createSlideBtn);
            this.Controls.Add(this.boldBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nxtImgBtn);
            this.Controls.Add(this.setImgBtn);
            this.Controls.Add(this.prevImgBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.searchImagesBtn);
            this.Controls.Add(this.contentBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PowerSlider_MainForm";
            this.Text = "PowerSlider";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.RichTextBox contentBox;
        private System.Windows.Forms.Button searchImagesBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button prevImgBtn;
        private System.Windows.Forms.Button setImgBtn;
        private System.Windows.Forms.Button nxtImgBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button createSlideBtn;
    }
}

