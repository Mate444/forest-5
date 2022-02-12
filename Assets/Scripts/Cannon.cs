using UnityEngine;

public class Cannon : MonoBehaviour {
  public GameObject prefab;
  public Vector3 pos;

  void Start() {
      Fire();
      Debug.Log(pos);
  }

  void Update() {
    
  }
  void Fire() {
    Instantiate(prefab, transform.position, transform.rotation);
  }
}