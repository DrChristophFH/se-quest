using Microsoft.AspNetCore.Mvc.ModelBinding;

using Quest.Logic;

using System.Threading.Tasks;

public class PlayerModelBinder : IModelBinder {
  private readonly GameLogic _gameLogic;

  public PlayerModelBinder(GameLogic gameLogic) {
    _gameLogic = gameLogic;
  }

  public Task BindModelAsync(ModelBindingContext bindingContext) {
    var headers = bindingContext.HttpContext.Request.Headers;
    Guid playerId = headers.ContainsKey("player-guid") ? Guid.Parse(headers["player-guid"].ToString()) : Guid.Empty;

    var player = _gameLogic.GetPlayer(playerId);

    if (player == null) {
      bindingContext.Result = ModelBindingResult.Failed();
      return Task.CompletedTask;
    }

    bindingContext.Result = ModelBindingResult.Success(player);
    return Task.CompletedTask;
  }
}
