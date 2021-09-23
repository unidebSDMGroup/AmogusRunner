# Game Mechanics:
## Player Character:
 - The player character will move up on the y-axis after pressing the spacebar using the transform function in unity.
 - If the user presses space bar and is in the air they cannot jump again.
 - The longer the user presses the spacebar the higher they jump.
 - To simulate smooth movement of a jump in the frame update function add the move towards method, using a specific speed multiplying with Time.deltaTime to keep smooth           transitions between multiple computers/devices.
 - The player character has a boxcollider attached to the sprite allowing for collision detection with other colliders.
 - If the player character boxcollider collides with an obstacle box collider we will reduce the player health to 0 triggering a scene transition to the game over/restart         screen.

## Obstacle:
 - Obstacles will be spawned randomly using a spawner, using the instantiate function and a random number generator.
 - Obstacles will have a box collider aswell, if the player box collider enters the obstacle box collider call the OnTrigger function within which we will remove 1 health         from the player character and destroy the obstacle.
