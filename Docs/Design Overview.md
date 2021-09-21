# Design Overview

## 1.Overview

The software system that is being developed is going to be a video game so it offers its own unique developmental challenges.
The game is going to be based on an endless runner template/genre where the player needs to clear obstacles in order to achieve the highest score possible.

## 2.Software requirements for development

Since the game is a 2d endless runner the software requirements are simply going to be a game engine and a 2d image manipulation software
- Unity
- Photoshop/GIMP

Further requirements for a finished polished game.
- Music creation application to be decided.

## 3.System features/game mechanics

Base game: Endless runner

Game mechanics will be based on this basic template (template specific mechanics).

- Player movement(simulated by moving the world instead of the player).
- Jump mechanic to clear obstacles.
- Score system.
- Local score logging system.

### Game specific mechanics

- Player chasing AI.
- Hit detection between player, obstacles and the AI (player should not be able to catch up to the AI).

## 4.Asset requirements

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

## 5.Deployment requirements

- Game is expected to be deployed on a Windows PC.
- Very basic and only requires basic hardware to run.
- Game can be ported to mobile(Android) with already existing features that facilitate this in Unity.
- iOS portability to be decided based on feasibility.
