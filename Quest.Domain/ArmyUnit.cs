namespace Quest.Domain;

public class ArmyUnit {
  private readonly string _name;
  private readonly int _attack;
  private readonly int _defense;
  private readonly int _health;

  public string Name => _name;
  public int Attack => _attack;
  public int Defense => _defense;
  public int Health => _health;

  public ArmyUnit(string name, int attack, int defense, int health) {
    _name = name;
    _attack = attack;
    _defense = defense;
    _health = health;
  }
}