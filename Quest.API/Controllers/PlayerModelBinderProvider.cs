using Microsoft.AspNetCore.Mvc.ModelBinding;

using Quest.Domain;
using Quest.Logic;

public class PlayerModelBinderProvider : IModelBinderProvider {
  private readonly GameLogic _gameLogic;

  public PlayerModelBinderProvider(GameLogic gameLogic) {
    _gameLogic = gameLogic;
  }

  public IModelBinder GetBinder(ModelBinderProviderContext context) {
    if (context.Metadata.ModelType == typeof(Player)) {
      return new PlayerModelBinder(_gameLogic);
    }
    return null;
  }
}
