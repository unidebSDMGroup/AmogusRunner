# Functional Specifications

## I . Overview

This document is more of a development oriented version of the requirements specifications.
In other words it can be considered a functional overview of what is theoretically possible during and after the development of said software/prodcut.



## II . Product Perspective

As per the customer requirements specification the product/game is of the 'endless runner' genre.
An endless runner is simply a game where the player has minimal controls when it comes to the axes(x,y,z).
And the game world speeds up to ramp up difficulty.

A very good simplistic example that can clearly explain this type of game would be the chrome offline game 'T-rex chrome'.
![back](/resources/images/trex.jpg)

## III . Product Features

As can be seen in the screenshot the game simply has 3 core mechanics that make it an endless runner.
- World speed
- Player jump
- Obstacles spawning

A finished game of this genre as mentioned before would likely have all of these mechanics mentioned above.

And for a finished product that is a game, elments such as
- a working menu system
- a score tracking system

are an obvious necessity.

## IV . Screen Plans

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

## V. Constraints

To develop these mechanics a game engine is a necessity.
(Games generally tend to run differently compared to standard applications)
A game engine can be built from screatch but considering the scope of the project this is not efficient or even necessary.
Using a free engine like Godot, Unity or Unreal might be more fitting.

For the scope of the project Unity is the most applicable. As it has
- Built in 2D game development features.
- Impoting to phone OS features.


## VI. Risk Analysis

Other than the gereal risks during any development these are what we may particularly face
- Testing resource defeciencies.
- Difference in the vision of the final composite product.

## VII . version control Requirements

Git and github are being used for version control. This is required because development of game elements are not strictly assigned to one team member/resource.
Another reason version control might be needed is because iterations are inevitable in a scrum based development model.

## VIII. Testing Requirements

- Playtesting is possible but cannot be extensive.
- Hardware compatability related testing is not possible.
