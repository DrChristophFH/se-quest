
using System;

namespace Quest.Domain;

public class Territory {
  private readonly string _name;
  private readonly int _armyUnits;
  private readonly Player _owner;

  public string Name => _name;
  public int ArmyUnits => _armyUnits;
  public Player Owner => _owner;

  public Territory(string name, int armyUnits, Player owner) {
    _name = name;
    _armyUnits = armyUnits;
    _owner = owner;
  }
}