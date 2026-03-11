# GDIM32 In Class Activities

## week 1
### activity 1: 

  go to office hours ask every things you don't know, do play test check your MG is worked. table 5

### activity 2:

  Q1: 10

  Q2: 2

  Q3: the method PrintMessage() have been called by Unity every frame it will output Hello World in Debug.Log part

  Q4: MonoBehaviour

  Q5: printMessage() have been called by unity once before the first Update method. it will output x = 10 in Debuf.Log part

  Q6: 10 is the parameter it defined value of int x when method is called. " x =" + x is the return of PrintMessage() method it is what things will output when PrintMessage() act

  Q7: Transform.Translate(_direction): is wrong Translate can only be called on an object it is a class

  Q8: _playerTransform instead of Transform 

### activity 3:

  [Week 1 table 5 activity 3](https://docs.google.com/document/d/15_HFzD7qHn72CA-2sku_BtfdMzhq6NBtRONPqSFgEHI/edit?tab=t.0)



## week 2
### activity 1:

MG2 Break down picture

<img width="1679" height="1196" alt="MG2 break down" src="https://github.com/user-attachments/assets/f5d994f6-ab4a-4149-bed2-838cadf790bd" />

### activity 2:

[ week 2 activity 2 work on MG2](https://github.com/UCI-GDIM32-W25/mg2-Ruichen-Ma-Martin/commit/418a3006e89186c2d052b6f361ba1d051923fa16)

## week 3
### activity 0-2:

chengxi jiang 

ruichen ma

### activity 3:

MG3 Break down picture

<img width="1681" height="1178" alt="In class W3" src="https://github.com/user-attachments/assets/345f80d3-aaaa-4760-b98e-8112e7e0ee86" />



## week 4
### activity 0:

chengxi jiang

ruichen ma

### activity 1:

I think if multipe Locator object in the scene, they will destroy utill only on Locator Object exit in the scene. because in Awake() it will check if there are some Instance exit but it is this it will destroy it.

### activity 2:

MG4 break down picture

![MG4 break down](https://github.com/user-attachments/assets/efedae87-3dca-43ac-85f5-3c394dfce063)

### activity 3:

[week 4 activity 3 work on MG4](https://github.com/Ruichen-Ma-Martin/HW4/commit/1f821b2465d9edb8884eaf921749cc820511dd79)

My work: I create new project. add bird and pip sprite sheet. build GameObject of bird, ground and pip. write script of bird jump



## week 5
### activity 1:

I think the structure of the interface and abstract is good and useful. But I think those mehtod can make a basic coding in the parent class if I build a same project.

### activity 2:

The class ItemW5Demo2 is the Model, it make a base Model of Item can generate different Item. EnemyStats is also Model for enemy

The class PlayerW5Demo2 is the Control which control player move and open Inventory. The class EnemyW5Demo2 is the Control of enemy

The class InventoryUI and DialogueBubble is the view which can be see by player.

### activity 3:

#### Scenario 1

view: UI of point

Control:player to control the when player touch the button they will get point

Model: use ScriptableObject to make model of different button

#### Scenario 2

View:UI, VFX, SFX

Control:player for shooting

Model:use scriptableObject to make model of different gun 

#### Scenario 3

View:InventoryIU, DialogueUI, animation, SFX.

Control:Player NPC Object(plant, stone)

Model:Items, NPC, Object (ScriptableObject)

Singleton: GameController (sent event)

### activity 4:

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

Proposal: [Final Project Proposal First Draft](https://docs.google.com/document/d/1xih16oloKwzPrgx0m7rAdHD8XQO2XJP5otpn2PSakoM/edit?tab=t.0#heading=h.y4j3q551ojs1)

## week 6
### activity 1

I think I can use Gizoms to check player shooting range and enemys moving direction. Also the Breakpoint is common way for debug in game. When I work on mini game, if there are some bug when I run the game in unity. I have to check which line of code have problem and run the logic of code line by line in my mind. But this Breakpoint can help me run the code in the Visual Studio. 

### activity 2

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

Proposal: [Final Project Proposal First Draft](https://docs.google.com/document/d/1xih16oloKwzPrgx0m7rAdHD8XQO2XJP5otpn2PSakoM/edit?tab=t.0#heading=h.y4j3q551ojs1)

## week 7
### activity 1

Raycast can check things it hit and out hitinfo

### activity 2

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

### activity 3

Break down image 


![Final project break down](https://github.com/user-attachments/assets/f998f993-e431-40cb-8183-01fc488e44ca)


### activity 4

assign initial task[Final project task chart](https://trello.com/b/CdYH9Ffo/gdim-32-final-project-list)

### activity 5

[work on check-in in class](https://github.com/EW1028/GDIM32-Final/commit/dbd40649d14edf5a8f213736e1b8f153c1c65fd3)

our work: build 3D GameObject of player and Ground/ player script of move

## Week 8
### activity 1

I learn how to use game asset of Rendering pineline and check wheather it can work 

### activity 2

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

### activity 3

playtest from Team: Froggiest Frog

The movement is a little bit slow, need to follow what player moves. When player is moving the gun should move as the player moves. Clear on the final target or goal. Add a crosshair to aim the target.

### activity 4

I will try to finish the feature gameplay part of The player can click on an item to interact with it


### activity 5

[work on check-in in class](https://github.com/EW1028/GDIM32-Final/commit/7fbb110a2ebc73a9f6710f24c0cf68eee5d254c4)

our work: finish weapon shooting and UI of target of shooting.

## Week 9
### activity 1

learn how code work in the demo 2 

### activity 2

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

### activity 3

During others testing, other players said our game’s movement has improved a lot compared with the last version. They suggested we adjust the reload cooldown, as they think the current reload time is too long and feels clunky. They also pointed out that the pistol having 100 bullets in our test build is a bit unreasonable. In addition, we should add NPC dialogue to guide new players, since some players who are new to FPS games tried to shoot with the Space key instead of the left mouse button. We also need to optimize the terrain, because the current map looks a bit plain.

We think our progress is still better than expected. Next, we will adjust the reload cooldown, balance the ammo amount, add player guidance through NPC dialogue, optimize the terrain and decorations, improve some code, add models for enemies and NPCs, and add more interactive elements in the level.

### activity 4

We finished improving the shooting animations for game characters last week. Players can now shoot and get hit feedback. We also added BGM and basic sound effects, such as shooting and reloading sounds, so the game has basic interactions. We improved the map as well, adding terrain and trees. Finally, we wrote code for NPCs but haven’t added them to the game yet.

We think our progress is better than expected. We still need to optimize the terrain and decorations, improve some code, and add NPC dialogue scripts to the game. We also plan to add models for enemies and NPCs, and include more interactive elements in the level.

### activity 5

[work on check-in in class](https://github.com/EW1028/GDIM32-Final/commit/52f57c003f7c352c46beaba0edbd86d3d7ea94e1)

our work debug the shooting logic and enemy logic

## week 10
### activity 1

Attendance: Ruichen Ma, Chengxi Jiang, Eric Wei

### activity 2

### activity 3

right i still need a quest system and option system in diaglogue/ Also I need a jump of 
We so far make the environment, the player now can walk to a NPC and talk to the NPC to interact. There are two targets that player can shoot them, after the HP(Lifes) are all gone they will automatically destory gameobject. We want to make the site better wiht move details add in, and improve more playing expericences. Almost done with this project but still have stuffs to do.

### activity 4

[work on check-in in class](https://github.com/EW1028/GDIM32-Final/commit/2ce587bd04f9346d63c9ff191d004639a841d8e7)

I work on Build dialogue system and option. 




