# 1. Current situation:

Endless games are one of the most popular video games where people try to do their best and get the highest score. That's why we aim to develop an among us themed endless runner game since this theme is still popular among people,  but unlike its original version in our game, there are two characters where one of them is chasing the other that adds extra excitement to the game.

The software system that is being developed is going to be a video game so it offers its own unique developmental challenges.

# 2. Dream Systems:

Our main development goal is to create a satirical amongus themed runner that keeps the player engaged to achieve a high score. It will be an endless runner / jumper, meaning the map will be moving from right to left. the player will be stationary ( even though it displays running animation ) The user has to control the character by using a key and that is jumping., In order to jump higher the user presses it twice. The user main goal here is to chase an AI based secondary character that will be able to jump. The user needs to catch up. It he doesn't under a certain limit it will result in game over and he have to restart again.


# 3. Current Processes:

In most of the endless games like Temple Run, Subway Surfers and Super Mario; main goal is to achieve the highest score possible. In order to achieve that players must overcome obstacles by jumping and they must do this in haste as the game goes faster the longer it goes, if the player is unable to overcome these challenges game will prompt the player with a game over screen.

# 4. Required Processes:

## Software requirements for development

Since the game is a 2d endless runner the software requirements are simply going to be a game engine and a 2d image manipulation software
- Unity
- Photoshop/GIMP

Further requirements for a finished polished game.
- Music creation application to be decided.

## System features/game mechanics

Base game: Endless runner

Game mechanics will be based on this basic template (template specific mechanics).

- Player movement(simulated by moving the world instead of the player).
- Jump mechanic to clear obstacles.
- Score system.
- Local score logging system.

### Game specific mechanics

- Player chasing AI.
- Hit detection between player, obstacles and the AI (player should not be able to catch up to the AI).

### Player

- Player sprites
- Player static animation(not essential)
- Player movement animation

### AI

- AI sprite
- AI likeness exactly similar to player except for colors so animations will be ported over.

### World

- Background, foreground and middlground world sprites(number of variances for each to be decided).

### Music

- Specifications to be decided further ahead during development.

# 5. Law, Rules, Standards:

## Player Character:
 - The player character will be affected by gravity using the rigidbody component in unity.
 - If the user presses space bar while the player is on the ground it will allow the player to jump using the vector2.up function.
 - The longer the user presses the spacebar the higher they jump, only for a certain duration of time after which the player will automatically begin to come down to the    ground.
 - If the user presses spacebar the isJumping variable will be set to true, if the user stops pressing space bar it will change the isJumping variable to false causing the    player to drop to the ground.
 - IF the user holds space bar while in the air the jumpTimeCounter variable will start to minus each second passing, if jumpTimeCounter reaches 0 the player will begin to    fall to the ground
 - The player character has a boxcollider attached to the sprite allowing for collision detection with other colliders.
 - If the player character boxcollider collides with an obstacle box collider we will reduce the player health to 0 triggering a scene transition to the game over/restart         screen.

## Obstacle:
 - Obstacles will be spawned randomly using a spawner, using the instantiate function and a random number generator.
 - Obstacles will have a box collider aswell, if the player box collider enters the obstacle box collider call the OnTrigger function within which we will remove 1 health         from the player character and destroy the obstacle.


## Screen-Plans :

 This section covers early concepts regarding the general look and aesthetic of the game.
 After all the major pieces were conceptualized, they were all complied in a screen plan shown below.
 The overall concept and asset creation were approached satirically;
 In essence, small parts were suggested and added to reinforce this idea.

 A few of these parts could be seen in the game background.
 The background was designed to be static and it includes faraway rocks and mounds
 as seen in the original among us map " Polus".
 The faraway standing figures are part of an online joke and their presence is purely comical.

 ![back](/resources/screenplans/amog.png)   


 The animation was planned to be simple considering the scope and simplicity of the Game.
 Two of the planned major keyframes are shown below. Other keyframes will be created to smooth the animation.

 ![animation](/resources/screenplans/anim.png)

 Below is a reference of the two Main characters. They have very similar design with different colors.
 The hand was added comically to enforce the idea of a chase.

 ![animation](/resources/screenplans/yes.png)

 The platform of the game will be composed of 4 different fixed sized blocks. these blocks will be
 spawn in a random order. As such, extra care needs to be put on the boarders of the individual blocks
 to ensure that any block could continue any other without breaking the illusion of continuity.
 The platform needed to be completely flat, yet the blocks themselves will contain minor transparent parts near the surface which shouldn't affect the running mechanics.
  this choice was purely aesthetic and non-technical.
 The Polus map included a lava pool therefore some blocks have a pool of lava below.
 
 ![animation](/resources/screenplans/blocks.png)


 With everything above put together, the screenplan is as follows.
 It Background color was intentionally darker to separate it from the foreground and a gradient was used to color the sky.

 ![plan](/resources/screenplans/screenplans.png)

# 6. Requirement list:


## Deployment requirements

- Game is expected to be deployed on a Windows PC.
- Very basic and only requires basic hardware to run.
- Game can be ported to mobile(Android) with already existing features that facilitate this in Unity.
- iOS portability to be decided based on feasibility.

## Functional requirements :

### Player :
Must be controllable with minimal delay ( regarding the jumping mechanic ).
### AI :
Responsive to the obstacles with acceptable accuracy.
Ensure The AI cannot lose the game or clip in an obstacle.
### UI :
Accessible and minimal with clear visual cues for starting the game, exiting or changing settings.
### Game Flow :
Must have one or more ways to fail the game and restart it.
Example : losing health will switch to a " Game over Screen" and prompt the player to restart the level.
A key could be assigned to pause and exist the game.
### Assets :
Must be visually coherent. should not contain any gaps or misplaces elements.
### Audio :
A simple repeating melody or song.
A simple sound indicating jumping and missing obstacles.

# 7. Dictionary:

## Visuals :

**UI** : User interface; components used to directly interact with the user. could be used to display useful
information or navigate though the game menus.

**Layer** : A collection of assets situated on the same prespective line from the camera's point of view.
addition of different layers with different transition speed creates the illusion of prespective.

**Sprite** : A 2D texture wrapper containing visual information to be directly used as part of the game's visuals.

## Systems & Mechanics :

**Jump Impulse** : Describes the way the player is able to move. An impulse in this case describes the suddent
positive change in the player's position on the Y-axis.
