# Maze Runner

Maze Runner is a first-person Unity game where players navigate through a maze, solve challenges, and complete the level while being timed. The game includes interactive features like doors that require keys, a leaderboard system for tracking scores, and a pause menu for seamless gameplay.

## Features

### Level 1 Gameplay
- Navigate a maze to find a key and unlock a door.
- **Door interaction**: Press `T` when near the door to open it if the key is collected.
- **Timer**: Tracks and displays the elapsed time in the format `Time: mm:ss` at the top-right corner of the screen.
- **Delay**: The door triggers a delay before loading the next scene.

### Leaderboard System
- After completing the level, players are taken to a SubmitName scene.
- Players input a 3-character name, which is saved along with their recorded time.
- The Leaderboard scene displays the names and times of all players.

### Pause Menu
- Integrated into the main scene (Level 1).
- Allows players to pause the game and access options.

### UI and Design
- **TextMeshPro** is used for all UI elements to ensure a polished look.
- Full-screen and normal screen compatibility for all UI prompts.

## Scenes
- **MainMenu (0)**: Start the game.
- **Level 1 (1)**: Main gameplay.
- **Leaderboard (2)**: View player scores.
- **SubmitName (3)**: Input your name after completing the level.

## Game Design

### Timer Script (GameTimer)
- Increments time using `Time.deltaTime` and calculates minutes and seconds.

### Door Interaction
- Players can open doors by pressing `T` if they have the required key.

### Name Entry Issue
- Resolved UI scaling issue where the name entry prompt didn’t display correctly in full-screen mode.

## Development Details

- **Engine**: Unity
- **UI Framework**: TextMeshPro

### Build Settings:
- **MainMenu**: Scene 0
- **Level 1**: Scene 1
- **Leaderboard**: Scene 2
- **SubmitName**: Scene 3

## How to Play

1. Start the game from the **Main Menu**.
2. Navigate the maze in **Level 1** to find the key.
3. Open the door by pressing `T` and proceed to the **SubmitName** scene.
4. Enter your 3-character name to save your score.
5. View your score on the **Leaderboard**.

## Installation

1. Open the project in Unity.
2. Build and run the game.

## Known Issues
- Full-screen compatibility for UI has been addressed.
- Further optimizations may be required for larger mazes and additional levels.

## Future Enhancements
- Add more levels with increasing difficulty.
- Introduce enemies or obstacles within the maze.
- Implement power-ups or collectibles.
- Expand the leaderboard to include global rankings.

## Credits
- **Developer**: Aarish Akbar Lakhani
- **Technologies Used**: Unity, TextMeshPro

## Contact
For questions or suggestions, feel free to reach out:

- **Email**: aarishlakhani2@gmail.com
- **GitHub**: [https://github.com/aarishlakhani](https://github.com/aarishlakhani)
