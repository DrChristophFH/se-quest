using Microsoft.AspNetCore.Mvc;

using Quest.Domain;
using Quest.Logic;

namespace Quest.API.Controllers;

[Route("api/game/stats")]
[ApiController]
public class StatsController : ControllerBase {
  private readonly GameLogic _gameLogic;

  public StatsController(GameLogic gameLogic) {
    _gameLogic = gameLogic;
  }

  [HttpGet]
  public IActionResult GetStats([ModelBinder] Player player) {
    var stats = player.Stats;
    return Ok(stats);
  }
}