using UnityEngine;

public class Player : MonoBehaviour {
  public Vector3 scale;
  public float speed;
  public Vector3 position;

  void Start() {
    HealthSystem playerHitpoints = new HealthSystem(100);
    playerHitpoints.Damage(10);
    playerHitpoints.Heal(10);
    playerHitpoints.Heal(10);
    playerHitpoints.Damage(110);
    transform.localScale = scale;
  }

  void Update() {
      transform.position += position * speed * Time.deltaTime;
  }
}
