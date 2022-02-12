using UnityEngine;
using System;
public class HealthSystem {
  private int health;

  public HealthSystem(int health) {
    this.health = health;
  }
  void Start() {
    
  }

  void Update() {
        
    }
  private const int maxHealth = 100;
  public void Heal(int amount) {
    health = Math.Min(maxHealth, amount + health);
  }

  private const int minHealth = 0;
  public void Damage(int amount) {
    health = Math.Max(minHealth, health - amount);
  }

  public int GetHealth() {
    return health;
  }
}
