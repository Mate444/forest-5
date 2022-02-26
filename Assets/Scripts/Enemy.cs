using UnityEngine;

public class Enemy : MonoBehaviour {
  public Transform playerPosition;
  public float speedRotation = 4f;
  public float speedMovement = 4f;
  public enum EnemyActivity {
    idle,
    chase,
    attack
  }
  public EnemyActivity enemyActivity;
  int enemyHP = 100; 
  void Start() {
 
  }

  void Update() {
    EnemyAction(enemyActivity);
  }

  void ChasePlayer() {
  float distance = Vector3.Distance(playerPosition.position, transform.position);
    if (distance >= 5) {
      transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, speedMovement * Time.deltaTime);
    }
  }
  void LookAtPlayer() {
    Quaternion rotation = Quaternion.LookRotation(playerPosition.position - transform.position);
    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speedRotation * Time.deltaTime);
  }
  void EnemyAction(EnemyActivity type) {
    switch (type) {
      case EnemyActivity.idle: 
        LookAtPlayer();
        break;
      case EnemyActivity.chase: 
        ChasePlayer();
        LookAtPlayer();
        break;
    }
  }
}
