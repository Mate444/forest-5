using UnityEngine;

public class Player : MonoBehaviour {
  public Vector3 scale;
  public float speed = 4f;
  public GameObject thirdPersonCamera;
  public GameObject skyCamera;
  public GameObject outfitCamera;
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
      Move();
      ToggleCamera();
  }
  void Move() {
    if (Input.GetKey(KeyCode.W)) {
      transform.Translate(new Vector3(-0.1f, 0, 0));
    }
    if (Input.GetKey(KeyCode.S)) {
      transform.Translate(new Vector3(0.1f, 0, 0));
    }
    if (Input.GetKey(KeyCode.A)) {
      transform.Translate(new Vector3(0, 0, -0.1f));
    }
    if (Input.GetKey(KeyCode.D)) {
      transform.Translate(new Vector3(0, 0, 0.1f));
    }
    /*float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);*/
  }
  void ToggleCamera() {
    if (Input.GetKey(KeyCode.V)) {
      thirdPersonCamera.SetActive(true);
      skyCamera.SetActive(false);
      outfitCamera.SetActive(false);
    }
    if (Input.GetKey(KeyCode.B)) {
      thirdPersonCamera.SetActive(false);
      skyCamera.SetActive(true);
      outfitCamera.SetActive(false);
    }
    if (Input.GetKey(KeyCode.N)) {
      thirdPersonCamera.SetActive(false);
      skyCamera.SetActive(false);
      outfitCamera.SetActive(true);
    }
  }
}
