# ProLexia
An application to add a coloured overlay onto the screen to help people with Irlen syndrome, visual stress and dyslexia read.

## Pre-requisites
In order to run ProLexia you need
- Windows 10
- [.NET Framework 4.8 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/net48) - you may have this already if you keep Windows up to date

## Install Instructions
1) Download the [latest Zip file](https://github.com/CultureBMo/ProLexia/releases/download/v1.2/ProLexia.1.2.0.0.zip)
2) Once downloaded open the Zip file and copy the contents
3) Paste into a new folder, e.g. C:\Program Files\Prolexia
4) Double click ProLexia.exe to run the program
5) Optionally - create a shortcut to the program on your desktop

## Using ProLexia
When ProLexia is running you will see a coloured pie chart in the system tray (i.e. bottom-right near the date and time).
If you right-click the icon you may choose:
- Options - this will open a dialog allowing you to choose the colour and alter the opacity
- Exit - this will stop ProLexia from running

## Technical Details
ProLexia was created using .NET 4.8 and the Windows API. 

It is a transparent Windows Form that is maximized and always on top, but allows the user to click through to applications underneath. The colour and opacity are set via an options menu accessible from the system tray.
