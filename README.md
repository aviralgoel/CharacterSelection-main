# 3D-Tank-Shooter
 <p align="center"> A 3D Tank <i>Tower Defence</i> Style Game created in Unity.
 
  <p align="center"><img src="TankDemo.gif" width="400" height="250"/></p>
 This is a learning project where I attempted to implement the **Model View Controller** Design Pattern to build a tank game. 
 To summarize I assigned the following responsibility to each component of the MVC:
 
 ### Model
 * Can only communicate back and forth with *Controller*
 * Hold the data about the tank in game (speed, color etc.)
 
 ### View
 * Can only communicate with *Controller*
 * Detects player input and passes it to the *Controller*
 * Changes the color of the tank when ordered by the *Controller*

### Controller
* Can Communicate with both *View and Model*
* Responsible for Player movement and rotation
* Orders View to change tank color


**Credits:** This project is part of my learning at Outscal.com
