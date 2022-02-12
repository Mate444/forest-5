using UnityEngine;

public class Player : MonoBehaviour {
  public Vector3 scale;
  public float speed;
  public Vector3 position;

  void Start() {
    HealthSystem playerHitpoints = new HealthSystem(100);
    playerHitpoints.Damage(10);
    Debug.Log(playerHitpoints.GetHealth());
    playerHitpoints.Heal(10);
    Debug.Log(playerHitpoints.GetHealth());
    playerHitpoints.Heal(10);
    Debug.Log(playerHitpoints.GetHealth());
    playerHitpoints.Damage(110);
    Debug.Log(playerHitpoints.GetHealth());
    transform.localScale = scale;
  }

  void Update() {
      transform.position += position * speed * Time.deltaTime;
  }
}
