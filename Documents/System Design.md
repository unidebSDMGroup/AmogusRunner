# System Design

## I . Purpose of the Product

- The purpose of this system is to enable gamers to have an experience in playing a game which is a synthesis of the endless game and one of today's popular themes "among us".

- It aims to have gamers a fun time while overcoming through obstacles and chasing AI.

- This game is designed for Windows PC and can be ported to mobile.

- For the sake of gamers,the color for background was chosen darker than the foreground's color to make the game more understandable.  

- To jump to stay away from the obstacles space bar should be pressed, the longer it is pressed the higher they jump.

- If the player cant get pass the obstacles, the game over/restart screen will showed.

## II . Project Plan
### 1 - Pre-study
This phase consists of analyzing, understanding and interpreting the given requirements and formulating a general plan of excution. This requires all team memembers to recognize both the required
constraints and the extent of our creative ability.
### 2 - Design
This phase consists of research and idea development for the purpose of shaping the desired model of our project. Both visual and architectural resources will serve as references in order to conceptualize the system.
### 3 - Implementation
This phase consists of the game creation. With designs and architectures being in place. we move on to writing code, creating assets and preforming tests.

## III . Business Project Model
This Project will use Business-to-business model. The finished product will be published to a gaming platform ( acting as a promoter ).


## IV . Requirement List

### 1 - General System Requirements
//explanation of the system compatibility and environment

### 2 - Visuals and UI Requirements
- The Block Assets must be coherent. This means that when placing any of the blocks next to another or an obstacle, both of the blocks seem as if they're connected. This could be done by leaving
empty outline gaps of each of the sides of each block while keeping the background color. this way, the outlines will not look chopped / cropped when placed in-game.
- The running animations must be looping with the 4 major keyframes and a few transitions in-between. Due to the simplicity of the game, both player and AI animations could be re-used with minimal details.
This animation is playing by default.
- The jumping animations must not be looping. They act as an interruption to the default running animation.
- A static background could act as a layer-0. Having the main platform move and the background static creates a tiny pararlellex effect.

### 3 - Audio Requirements
//describe somewhat technically the variety of audio tracks/sound effects and what
you're trying to achieve with them

### 4 - Functional Requirements

- class diagram

![back](/Documents/diagrams/ClassDiagram.png)

- ERD diagrams

![back](/Documents/diagrams/AmogusERD.png)
## V . Functional Design

## VI . Game-Flow
![back](/Documents/diagrams/GameFlowDiagram.png)

## VII . Use Case
![back](/Documents/diagrams/UIUseCaseDiagram.jpg)

## VIII . plan schedule
| MILESTONE     | DEADLINE |
| ----------- | ----------- |
| pre-study      | 13st sep 2021 |
| design   | 26st sep 2021 |
| implementation | 3rd oct 2021 |

## IX . Testing Plan
- blocks generating randomly
- obstacles generating randomly
- player able to jump over Obstacles
- UI navigation


## X . Deployment Plan
// unity -> export launcher

## XI . Maintenance Plan
This game will be finilized with a clear end-goal in mind. this means that it will most likely not be developed further, this includes adding more features.
small quality of life additions and bugfixes however will be added in the upcoming versions.
