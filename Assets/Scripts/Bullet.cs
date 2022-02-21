using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public int speed = 20;
    public Vector3 bulletScale;
    public GameObject spawnPoint;
  void Start() {
        
  }

  void Update() {
    transform.position += transform.forward * speed * Time.deltaTime;
    if (Input.GetKeyDown("space")) {
      transform.localScale += bulletScale * 2;
      transform.rotation = spawnPoint.transform.rotation;
    }
  }
}
