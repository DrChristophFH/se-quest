using Microsoft.AspNetCore.Mvc;

using Quest.Logic;

namespace Quest.API.Controllers;

[Route("api/game/log")]
[ApiController]
public class LogController : ControllerBase {
  private readonly GameLogic _gameLogic;

  public LogController(GameLogic gameStateService) {
    _gameLogic = gameStateService;
  }

  // [HttpGet]
  // public IActionResult GetLog([FromQuery] int h = 10) {
  //   var logs = _gameLogic.GetActionLogs(h);
  //   return Ok(logs);
  // }
}
