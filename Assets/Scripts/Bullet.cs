using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public Vector3 direction;
    public int speed = 20;
  void Start() {
        
  }

  void Update() {
    transform.Translate(direction * Time.deltaTime * speed);
  }
}
