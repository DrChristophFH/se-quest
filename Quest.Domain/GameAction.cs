namespace Quest.Domain;

public class GameAction {
  public int Id { get; set; }
  public string Action { get; set; } = null!;
  public DateTime Timestamp { get; set; }
  public int PlayerId { get; set; }
  public Player Player { get; set; } = null!;
}