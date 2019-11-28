# Stellaris Surround GUI

This is a mod for the video game Stellaris.

When playing the game with multi-monitor tools like NVIDIA Surround, the GUI will stretch itself accross all monitors.
This makes the player have to constantly turn their head to see the GUI elements, as most elements in this game are bound to 
either the left or right side of the screen.

This mod essentially changes the UI to be bound to the inner edges of the monitors instead of the outer edges. This is to make use of the extra monitor space, without all of the head turning. That way you get all the awesomness of NVIDIA surround, with none
of the pain of GUI all over the place.

![alt text](https://raw.githubusercontent.com/mctricks/Stellaris-Surround-GUI/master/Version2-Example1.jpg)
![alt text](https://raw.githubusercontent.com/mctricks/Stellaris-Surround-GUI/master/Version2-Example2.jpg)

This was created for three 1080p monitors using NVIDIA Surround, with a 48 pixel bezel between each monitor (5856 x 1080). 

I created a tool to generate new versions of this mod that work with any bevel size, though you will need to compile it yourself currently. It's a C#.NET Console app made in VS Code. The parameters to change are in the StellarisReplacementData.cs folder.

KNOWN ISSUE: There's no way I've found to have the left bar be expandable and have it look right, so I've modified the files to only work as the unexpanded version. You will need to lock your sidebar for it to work right.

![alt text](https://raw.githubusercontent.com/mctricks/Stellaris-Surround-GUI/master/Example-1.jpg)
![alt text](https://raw.githubusercontent.com/mctricks/Stellaris-Surround-GUI/master/Example-2.jpg)

