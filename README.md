# SE-Quest

## Overview

This project is a backend implementation for a strategy game similar to Risk, played entirely through REST API calls. The game is designed as an ASP.NET Core Web API application, where players interact with the game world by making HTTP requests. Each player is identified by a unique GUID, and the game progresses in rounds with actions like move, attack, build, and negotiate.

## Creator

- [DrChristoph](<[Your-Profile-Link](https://github.com/DrChristophFH)>) - Initial work and concept.

## Game Description

In this strategy game, players join a virtual game board, manage resources, build their empires, and engage with other players through strategic moves. The game operates on a fixed timestep, with each round allowing players a set number of actions. Key features include:

- Joining a game and receiving a unique player ID.
- Executing limited actions (move, attack, build) each round.
- Querying player stats and game logs.
- Trading and negotiating with other players.
- Forming alliances and engaging in battles.

Sure, let's detail the game description along with the available API endpoints and their functionalities for your strategy game where players spawn as nations and can engage in combat with each other.

### Game Concept
In this strategy game, players assume the roles of leaders of different nations. Each player, upon joining the game, is assigned a unique nation with specific resources and capabilities. The goal is to strategically manage resources, expand territory, form alliances, and engage in combat with other nations. The game progresses in rounds, with each player making decisions that will affect their nation's success.

A round takes a fixed amount of time. Each player is allowed a set number of actions per round, which they can use to move troops, attack other nations, build infrastructure, or engage in diplomacy. Querrying information is usually free. Actions are staged by the player during the round and committed at the end of the round. During the round staged actions can be changed or canceled. 

### API Endpoints

#### 1. Join Game
- **Endpoint**: `GET /api/game`
- **Description**: New players use this endpoint to join the game. It assigns them a unique nation and player ID (GUID). The player id needs to be supplied in the header 'player-id' for all subsequent requests to the API.
- **Response**: A JSON object containing the player's GUID and initial nation details.



## Getting Started

To run this project, you will need:

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- A code editor like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).

Clone the repository and use `dotnet run` to start the application.

## Coding Guidelines

- **File Scoped Namespaces**: Use file-scoped namespaces to keep the code concise.
- **Java Bracket Style**: Place opening brackets on the same line.
- **Indentation**: Use 2 spaces for indentation.
- **Comments**: Write meaningful comments and XML documentation for API methods and controllers.

Example:

```csharp
namespace StrategyGame.Api

[ApiController]
public class GameController {
  // Methods and implementation
}
```

## License

This project is licensed under the [MIT License](LICENSE.md) - see the LICENSE file for details.
