using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public int speed = 20;
  void Start() {
        
  }

  void Update() {
    transform.position += transform.forward * speed * Time.deltaTime;
  }
}
