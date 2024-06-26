# ProLexia
An application to add a coloured overlay onto the screen to help people with Irlen syndrome, visual stress or dyslexia.

<img src="https://3.bp.blogspot.com/-9k0dX5dO_Vo/VCe0op9HCEI/AAAAAAAAAB0/rM6D5gH2T9c/s1600/ProLexia%2BOptions.JPG" height="326" width="400" />

## Pre-requisites
In order to run ProLexia you need
- Windows 10
- [.NET 8 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) - you may have this already, but if not you will be prompted to download it, see below

## Install Instructions
1) Download the [Zip file for the latest release of ProLexia](https://github.com/CultureBMo/ProLexia/releases/download/v4.0/ProLexia.4.0.0.0.zip)
2) In your Downloads folder right-click the Zip file and choose Extract All..
3) Choose a folder to extract into, e.g. C:\Program Files\ProLexia
4) Double click ProLexia.exe to run the program. If you don't have the latest version of .NET you will be prompted to [download it](https://dotnet.microsoft.com/en-us/download/dotnet/8.0). On the download page, under Run desktop apps, click Download x64
5) Optionally - create a shortcut to the program on your desktop

## Using ProLexia
When ProLexia is running you will see a coloured pie chart in the system tray (i.e. bottom-right near the time and date).
If you right-click the icon you may choose:
- Options - this will open a dialog allowing you to change the colour and the opacity
- Exit - this will stop ProLexia from running

## Technical Details
ProLexia was created using .NET 8 and calls to the Windows API.<br/>
It is a transparent Windows Form that is maximized and always on top, but allows the user to click through to applications underneath. The colour and opacity are set via an options menu accessible from the system tray.<br/>
StyleCop Analyzers are used to enforce coding standards.<br/>
GitHub Copilot was used to optimize some of the code.
