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
In this strategy game, players assume the roles of leaders of different nations. Each player, upon joining the game, is assigned a unique nation with specific resources and capabilities. The goal is to strategically manage resources, expand territory, form alliances, and engage in combat with other nations. The game progresses in turns, with each player making decisions that will affect their nation's success.

### API Endpoints

#### 1. Join Game
- **Endpoint**: `GET /api/game`
- **Description**: New players use this endpoint to join the game. It assigns them a unique nation and player ID (GUID).
- **Response**: A JSON object containing the player's GUID and initial nation details.

#### 2. Player Stats
- **Endpoint**: `GET /api/game/stats`
- **Description**: Retrieves the current statistics and status of the player's nation, including resources, military strength, and technological advancements.
- **Response**: Detailed stats of the player's nation.

#### 3. Action Log
- **Endpoint**: `GET /api/game/log?h=10`
- **Description**: Fetches the log of the last 'h' number of actions performed in the game, providing insight into recent events and moves by other nations.
- **Response**: A list of recent actions taken in the game.

#### 4. Perform Action
- **Endpoint**: `POST /api/game/action`
- **Description**: Players use this endpoint to perform various actions like moving troops, attacking other nations, or engaging in diplomacy.
- **Request Body**: Details of the action, including type and target.
- **Response**: Outcome of the action.

#### 5. Game Map
- **Endpoint**: `GET /api/game/map`
- **Description**: Provides a view of the game world, showing territories, resources, and positions of different nations.
- **Response**: Current state of the game map.

#### 6. Trade/Negotiate
- **Endpoint**: `POST /api/game/trade`
- **Description**: Allows nations to trade resources or negotiate treaties with others.
- **Request Body**: Trade or negotiation details.
- **Response**: Result of the trade or negotiation.

#### 7. Upgrade/Research
- **Endpoint**: `POST /api/game/upgrade`
- **Description**: Players can invest in upgrades or research to improve their nation's capabilities.
- **Request Body**: Specifics of the desired upgrade or research.
- **Response**: Status of the upgrade or research initiative.

#### 8. Round Summary
- **Endpoint**: `GET /api/game/roundSummary`
- **Description**: At the end of each turn, this provides a summary of significant events and changes in the game world.
- **Response**: Summary of the events and changes occurred during the round.

#### 9. Form Alliance
- **Endpoint**: `POST /api/game/alliance`
- **Description**: Enables players to form alliances with other nations for mutual benefit.
- **Request Body**: Details of the alliance proposal.
- **Response**: Outcome of the alliance proposal.

#### 10. Surrender/Withdraw
- **Endpoint**: `POST /api/game/surrender`
- **Description**: Allows a player to surrender or withdraw their nation from the game.
- **Request Body**: Confirmation of the decision to surrender.
- **Response**: Acknowledgment of the nation's surrender or withdrawal.

### Gameplay Mechanics
Players must strategically manage their nation's resources, engage in diplomacy, and sometimes engage in warfare to expand their territory and influence. The game requires careful planning and decision-making to balance development, defense, and expansion. Success in the game is measured by the player's ability to grow their nation into a dominant power.

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
