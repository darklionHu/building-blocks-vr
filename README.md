# vr-challenge

for setup:

use unity 2021.3.19f1 (LTS) if possible.

from package manager download xr interaction toolkit and its starter assets.
if any errors occur make sure you did setup the input action manager on the XR Origin object, and imported the default templates for both hands.


short description about the scripts:

CubeController.cs is assigned to the cubes that get instantiated in the scene. it manages the movement and snapping for the cube

InputsManager.cs stores data for inputs (rn it only stores data for the grip force)

MeshCombiner.cs combines meshes and updates the collisions for it.

ObjectData.cs stores data as a scriptable object

SaveMesh.cs saves and loads the mesh (even though the name is SaveMesh.cs, it can also load lol)

TraySystem.cs turned out to be really crappy to be honest.


demo:
https://www.youtube.com/watch?v=5tbqDZ3YC7Y&ab_channel=DarkLionGames
