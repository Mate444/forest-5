using System;
using UnityEngine;

public class Cannon : MonoBehaviour {
  public GameObject prefab;
  public GameObject spawnPoint;

  void Start() {
      Fire();
  }

  void Update() {
    if (Input.GetKeyDown("j")) {
        FireBarrage(2);
      }
      if (Input.GetKeyDown("k")) {
        FireBarrage(3);
      }
      if (Input.GetKeyDown("l")) {
        FireBarrage(4);
      }
  }
  void Fire() {
    Instantiate(prefab, spawnPoint.transform.forward, spawnPoint.transform.rotation);
  }
  void FireBarrage(int times) {
    for (int i = 0; i < times; i++)
    {
      Instantiate(prefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }
  }
}