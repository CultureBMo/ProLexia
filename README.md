# ProLexia
An application to add a coloured overlay onto the screen to help people with Irlen syndrome, visual stress and dyslexia read.

## Pre-requisites
In order to run ProLexia you need
- Windows 7 or later
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)

## Install Instructions
1) Go to the [latest release page](https://github.com/CultureBMo/ProLexia/releases/tag/v1.1)
2) Click the Zip file - this will start the download
3) Once downloaded open the Zip file and copy the contents
4) Paste into a new folder, e.g. C:\Program Files\Prolexia
5) Double click ProLexia.exe to run the program
6) Optionally - create a shortcut to the program on your desktop

## Using ProLexia
When ProLexia is running you will see a coloured pie chart in the system tray (i.e. bottom-right near the date and time).
If you right-click the icon you may choose:
- Options - this will open a dialog allowing you to choose the colour and alter the opacity
- Exit - this will stop ProLexia from running

## Technical Details
ProLexia was created using .NET 4.8 and the Windows API. 

It is a transparent Windows Form that is maximized and always on top, but allows the user to click through to applications underneath. The colour and opacity are set via an options menu accessible from the system tray.
