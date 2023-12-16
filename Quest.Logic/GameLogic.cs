using Quest.Domain;

namespace Quest.Logic;

public class GameLogic {
  private static readonly object _lock = new object();

  // map player guids to the game they are currently playing
  private static readonly IDictionary<Guid, Game> games = new Dictionary<Guid, Game>();
  private static readonly IDictionary<Guid, Player> players = new Dictionary<Guid, Player>();

  // active games
  private static readonly IList<Game> gameList = new List<Game>();

  public Player JoinGame() {
    lock (_lock) {
      Player newPlayer = new Player {
        Id = Guid.NewGuid()
      };
      players.Add(newPlayer.Id, newPlayer);

      return newPlayer;
    }
  }

  public Player GetPlayer(Guid playerId) {
    lock (_lock) {
      var player = players[playerId];
      if (player == null) return null;

      return player;
    }
  }
}
