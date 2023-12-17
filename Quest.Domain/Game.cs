using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Timers;

namespace Quest.Domain;

public class Game {
  // --- Game Info ---
  private readonly int _maxPlayers;
  private readonly int _roundTime = 60;
  private readonly object _lock = new();
  private readonly Guid _id = Guid.NewGuid();
  private readonly DateTime _created = DateTime.UtcNow;

  // --- Game Mechanics ---
  private readonly CombatResolver _combatResolver = new CombatResolver();

  // --- Game State ---
  private readonly List<Player> _players = new();
  private bool _started = false;
  private int _round = 0;

  // --- Round State
  private readonly ConcurrentQueue<Attack> _queuedAttacks = new();

  // --- Properties ---
  public Guid Id => _id;
  public DateTime Created => _created;
  public IReadOnlyList<Player> Players => _players;
  public int Round => _round;
  public bool IsFull() => _players.Count >= _maxPlayers;

  // --- Methods ---

  public Game(int maxPlayers) {
    _maxPlayers = maxPlayers;
  }

  public bool AddPlayer(Player player) {
    lock (_lock) {
      if (_players.Contains(player)) return false;
      if (_players.Count >= _maxPlayers) return false;

      _players.Add(player);
      return true;
    }
  }

  public void Start() {
    lock (_lock) {
      if (_started) return;

      _started = true;

      // periodicaly call NextRound every _roundTime seconds
      var timer = new Timer(_roundTime * 1000);
      timer.Elapsed += (sender, e) => NextRound();
    }
  }

  public void NextRound() {
    lock (_lock) {
      if (!_started) return;

      ProcessAttacks();
      ProcessTrades();
      MoveUnits();
      HandleProduction();
      BuildStructures();

      ResetMoveLimits();

      _round++;
    }
  }

  /// <summary>
  /// Processes all queued attacks by resolving them using the combat resolver.
  /// </summary>
  private void ProcessAttacks() {
    // Resolve all queued attacks first
    while (!_queuedAttacks.IsEmpty) {
      if (!_queuedAttacks.TryDequeue(out var attack)) continue;
      _combatResolver.resolveAttack(attack);
    }
  }

  /// <summary>
  /// Processes all trades
  /// </summary>
  private void ProcessTrades() {
    // Implement trade processing logic
  }

  /// <summary>
  /// Moves units 
  /// </summary>
  private void MoveUnits() {
    // Implement units movement logic
  }

  /// <summary>
  /// Handles production
  /// </summary>
  private void HandleProduction() {
    // Implement production handling logic
  }

  private void BuildStructures() {
    // Implement structure building logic
  }

  private void ResetMoveLimits() {
  }

  public void QueueAttack(Attack attack) {
    _queuedAttacks.Enqueue(attack);
  }
}