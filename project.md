#Project
##Assets
###Img (unimportant)
Texture for the EyeBallModel
###Imported_fbx (unimportant)
Imported EyeBallModel.fbx
###Materials (unimportant)
Materials for game objects
###Prefab (unimportant)
Game objects for experimentation
###Preprocessed (unimportant)
Materials like video or customized texture
###Resources
All facial images that will be displayed by the game object FaceScreens

* mesh: Candide 3D mesh for face recognition
* stage1: Images for the sorting process, stage1
* stage2: Images for the sorting process, stage2
* stage3: Images for the sorting process, stage3
* stage4: Images for the sorting process, stage4

###Scene
The main scene of this project
###Scripts (important)
The scripts that are used in this project

* ImageSequencesSingleTexture: Controlling which image should be displayed on each faceScreen
* MainController: Controlling the stages according the user's position. It contains main parameters (properties) for other scripts.
* MovPlayBack: Looping the video texture
* SaveWebCamImg: controlling what size and how many of WebCam images should be saved to the folder of stage4.
* unused (unimportant)
* Webcam: showing WebCam image on the game object WebCamScreen

###Standard Assets (unimportant)
Basic character controllers and scripts for mouse and keyboard control

===
#Game Object Hierarchy
##FaceScreens
The script ImageSequencesSingleTexture is attached on all faceScreen
##SaveWebCamImage
The game object to implement the script SaveWebCamImg
##End (unimportant)
The destination
##EyeBallModel
The main 3D model in the scene
##Lights
For light shading in the scene
##WebCamScreen
Displaying WebCam image
##User
The user
##MainController
The game object to implement the script MainController
  