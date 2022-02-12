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
  public int Heal(int amount) {
    if (health == 100) {
      return health;
    }
    
    if (health + amount > 100) {
      health = 100;
      return health;
    }

    return health += amount;
  }

  public void Damage(int amount) {
    if (health - amount <= 0) {
      health = 0;
    } else {
      health -= amount;
    }
  }

  public int GetHealth() {
    return health;
  }
}
