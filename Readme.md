# Mortal Kombat

**Author**: Luay Younus
**Version**: 1.0

## Overview
This is a mini game from the famous Mortal Kombat to practice C# interfaces. The game demonstrates Players classes implementing interfaces and an abstract class being derived.

## Requirements to run the Application
- [Visual Studio 2017 Community with .NET Core 2.0 SDK](https://www.microsoft.com/net/core#windowscmd)
- [GitBash / Terminal](https://git-scm.com/downloads) or [GitHub Extension for Visual Studio](https://visualstudio.github.com)

## Diagram
![InterfacesDiagram](InterfacesMortalKombat.png?raw=true "Inheritance")

## Getting Started
1. Clone the repository to your local machine.
2. Cd into the application directory where the `AppName.sln` exist.
3. Open the application using `Open/Start AppName.sln`.
4. Once Visual Studio is opened, you can Run the application by clicking on the Play button <img src="https://github.com/luayyounus/Lab02-Unit-Testing/blob/Lab02-Luay/WarCardGame/play-button.jpg" width="16"> and the console game will run.
5. A welcome message with instructions will be displayed to teach you how to play the console game.
**Note**: Press the `Enter` key whenever you are stuck.

## Game Experience
 The game allows the user to assign new characters and fight with a Kick or Punch movements. The progress of the game shows the Initials of every player and defender's names. The following are the rules applied:
 - Player One always wins, no matter what.
 - Player One has the right to either Kick or Punch once at a time with a certain damage caused to Player two.
 - Player One is allowed to Walk or Run which leads both players to move forward in the battle field.
 - Player Two has the right to Cover up to reduce health damage.
 - Player Two loses whenever their health is below 1, Or when the edge of the battle ground is reached.

## Architecture
 - C# Console Core application.
 - Interfaces are being implemented by each player to execute an action during the game.
 - Player class is a base abstract class that holds the properties and actions both needed by PlayerOne and PlayerTwo.
 - Derived classes use Constructors with customed values to speed up the fight starting stage.
