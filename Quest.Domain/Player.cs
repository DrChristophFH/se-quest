namespace Quest.Domain;

public class Player {
  public Guid Id { get; set; }
  public PlayerStats Stats { get; set; } = new();
}