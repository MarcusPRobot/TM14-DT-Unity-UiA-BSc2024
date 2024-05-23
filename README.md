# Omron TM14 Unity Digital Twin - Development of a Digital Twin platform for an autonomous pick-and-place operation
This Unity project is created to simulate a virtual environment of an Omron TM14 collaborative robot, using a server client script set up to communicate through UDP packages. It can only convert incoming data using a specific input format which is controlled by the communication server. How everything is set up is explained within the bachelor's report.

# Sources
Copilot is used to some degree in almost every script to help with coding effeciency, but most of the structure of most scripts are thought out by the developer and used to inspire Copilots future prompts. In scripts where other sources were used the source is listed below the script classes.

The project uses the following package from Github:
**URDF-Importer**
https://github.com/Unity-Technologies/URDF-Importer?tab=readme-ov-file

And it also builds upon our supervisor, Even Falkenbergs', unity base project for simulating a TM-14 robot: 

**Omron TM14 Unity ROS2**
https://github.com/evenlangas/omrontm14-unity-ros2/tree/main

# Communication server and its nodes
**Bachelor-g2-v24**
https://github.com/EliasLand/TM14-DT-Node-RED-ROS2-UiA-BSc2024

**PLC Programming files**
https://github.com/TorePang/PLC-programming/tree/main

**Project video**
https://www.youtube.com/watch?v=saMr48I3a2o

**Repository with all llinks**
https://github.com/MarcusPRobot/UiA-BScThesis-S24-G2/blob/main/README.md

# Program scripts
The self-developed scripts are found within **TM14_DT_BSc2024\Assets\Scripts**, scripts found outside of that folder is most likely imported through Assets or moved away as they were no longer in use.
