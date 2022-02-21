using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public float seconds = 4f;
    void Start()
    {
      Destroy(this.gameObject, seconds);
    }

    void Update()
    {
        
    }
}
