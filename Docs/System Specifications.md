# Game Mechanics:
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
