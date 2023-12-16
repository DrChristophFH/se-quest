using Microsoft.AspNetCore.Mvc;

using Quest.Domain;
using Quest.Logic;

namespace Quest.API.Controllers;

[Route("api/game")]
[ApiController]
public class GameController : ControllerBase {
  private readonly GameLogic _gameLogic;

  public GameController(GameLogic gameLogic) {
    _gameLogic = gameLogic;
  }

  [HttpGet]
  public IActionResult JoinGame() {
    var player = _gameLogic.JoinGame();
    return Ok(player); // Return the player with GUID
  }

  // [HttpPost("action")]
  // public IActionResult PerformAction([FromBody] GameAction action) {
  //   var result = _gameLogic.PerformAction(action);
  //   return Ok(result);
  // }

  // Add other endpoints as needed
}