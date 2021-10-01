# Requirement Specification

## I. Current Situation

Endless games are one of the most popular video games where people try to do their best and get the highest score. That's why we aim to develop an among us themed endless runner game since this theme is still popular among people, but unlike its original version in our game, there are two characters where one of them is chasing the other that adds extra excitement to the game.

## II. Dream System

Our main development goal is to create a satirical amongus themed runner that keeps the player engaged to achieve a high score. It will be an endless runner / jumper, meaning the map will be moving from right to left. the player will be stationary ( even though it displays running animation ) The user has to control the character by using a key and that is jumping., In order to jump higher the user presses it twice. The user main goal here is to chase an AI based secondary character that will be able to jump. The user needs to catch up. It he doesn't under a certain limit it will result in game over and he have to restart again.

## III. Current Processes

In most of the endless games like Temple Run, Subway Surfers and Super Mario; main goal is to achieve the highest score possible. In order to achieve that players must overcome obstacles by jumping and they must do this in haste as the game goes faster the longer it goes, if the player is unable to overcome these challenges game will prompt the player with a game over screen.

## IV. Required Processes

### Software requirements for development

Since the game is a 2d endless runner the software requirements are simply going to be a game engine and a 2d image manipulation software.

- Unity
- Photoshop/GIMP

Further requirements for a finished polished game.
Music creation application to be decided.

### System features/game mechanics

Base game: Endless runner

Game mechanics will be based on this basic template (template specific mechanics).

- Player movement(simulated by moving the world instead of the player).
- Jump mechanic to clear obstacles.
- Score system.
- Local score logging system

#### Game specific mechanics

- Player chasing AI.
- Hit detection between player, obstacles and the AI (player should not be able to catch up to the AI).

#### Player

- Player sprites
- Player static animation(not essential)
- Player movement animation

#### AI

- AI sprite
- AI likeness exactly similar to player except for colors so animations will be ported over.

#### World

- Background, foreground and middlground world sprites(number of variances for each to be decided).

#### Music

- Specifications to be decided further ahead during development.

## V. Rules

### Player Character

- The player character will be affected by gravity using the rigidbody component in unity.
- If the user presses space bar while the player is on the ground it will allow the player to jump using the vector2.up function.
- The longer the user presses the spacebar the higher they jump, only for a certain duration of time after which the player will automatically begin to come down to the ground.
- If the user presses spacebar the isJumping variable will be set to true, if the user stops pressing space bar it will change the isJumping variable to false causing the player to drop to the ground.
- IF the user holds space bar while in the air the jumpTimeCounter variable will start to minus each second passing, if jumpTimeCounter reaches 0 the player will begin to fall to the ground
- The player character has a boxcollider attached to the sprite allowing for collision detection with other colliders.
- If the player character boxcollider collides with an obstacle box collider we will reduce the player health to 0 triggering a scene transition to the game over/restart screen.

### Obstacle

- Obstacles will be spawned randomly using a spawner, using the instantiate function and a random number generator.
- Obstacles will have a box collider aswell, if the player box collider enters the obstacle box collider call the OnTrigger function within which we will remove 1 health from the player character and destroy the obstacle.

## VI. Requirement List

## VII. Dictionary