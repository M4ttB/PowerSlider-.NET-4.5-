PowerPoint Slide Creator in C# takes Keywords from Title and bolded words in the Content box and searches for images from " free-images.com ".
No 3rd party APIs were used for this project. Only official Microsoft APIs. Thank you for downloading and please leave behind some helpful comments.

To Run, extract the "PowerSlider.Install.zip" folder and run "PowerSlider.exe"

Future Improvements:
1. Interactive Feedback
2. Exception/Error Handling (Done)
3. Alternative Image Search Engine?

Changes:
Rebuilt project in Visual Studio 2013 with .NET Framework 4.5









NuGet was having some problems on my end installing the project (Visual Studio 2013). After running these two commands at the command line the problem went away. I'm gonna put these here in case I need to refer back to them.
reg add HKLM\SOFTWARE\Microsoft\.NETFramework\v4.0.30319 /v SystemDefaultTlsVersions /t REG_DWORD /d 1 /f /reg:64
reg add HKLM\SOFTWARE\Microsoft\.NETFramework\v4.0.30319 /v SystemDefaultTlsVersions /t REG_DWORD /d 1 /f /reg:32
