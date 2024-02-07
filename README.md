# Knot-Showcase-VR

This will be made into a final build, but the source code is here.

Gallery View:<br><br>

![alt text](https://raw.githubusercontent.com/bday336/Knot-Showcase-VR/main/gallery_image.png)

Specific Knot View:<br><br>

![alt text](https://raw.githubusercontent.com/bday336/Knot-Showcase-VR/main/trefoil_image.png)

___________________________________
Make local version in Unity
___________________________________

When making a local version of the program with Unity, make sure that you have an editor setup so that the scripts can be opened when working with the source code. I have been using Microsoft Visual Studio which connects with the Unity project if it is set as the Unity editor. (If no editor is set, this will cause problems). I think it is also necessary to have a personal Unity account so as to manage plug-ins (particularly SteamVR)

Begin by creating a new Unity project using the 3D template. Download the github repository as a zip file to your local machine. Unzip the local repository files and copy then over to the new Unity project directory. This will install the SteamVR plug-in automatically and configure the controls. It might take some time to process after the files are copied, especially if the project is currently open. Once all the files have been configured the program should be complete functional. Have fun!


___________________________________
Functionality / Controls
___________________________________

Currently the gallery consists of a variety of 3D models of some common mathematical knots. This is completely extendable such that more knots can be included. Alternatively, the knots can be exchanged for different objects to suit specific needs. Interacting with the stand underneath the floating model teleports user to empty room with specific model for closer perspective and more interactivity (rotate model in 3D).

Controls:<br><br>
![alt text](https://raw.githubusercontent.com/bday336/Knot-Showcase-VR/main/Controls%20Manual.png)

For Left Controller:
<br>Button 1 - Currently not assigned<br>
<br>Button 2 - Place object held in hand at current position in the scene<br>
<br>Button 3 - Change object held by controller (currently switches between test particle and nothing, i.e. empty hand)<br>
<br>Button 4 - Activate and deactivate the flow of test particles<br>

Right Controller:
<br>Button 1 - Teleport user to the position of the teleport pointer (if teleport function is active)<br>
<br>Button 2 - Grab object placed in scene<br>
<br>Button 3 - Reset the scene (delete all the test particles present)<br>
<br>Button 4 - Activate and deactivate the teleport function for the user<br>
