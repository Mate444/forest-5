using UnityEngine;

public class Player : MonoBehaviour {
  public Vector3 scale;
  float speed = 40f;
  public GameObject thirdPersonCamera;
  public GameObject skyCamera;
  public Vector3 position;

  void Start() {
    HealthSystem playerHitpoints = new HealthSystem(100);
  }

  void Update() {
      Move();
      ToggleCamera();
      RotateCharacter();
  }
  void Move() {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
  }
  void ToggleCamera() {
    if (Input.GetKey(KeyCode.V)) {
      thirdPersonCamera.SetActive(true);
      skyCamera.SetActive(false);
    }
    if (Input.GetKey(KeyCode.B)) {
      thirdPersonCamera.SetActive(false);
      skyCamera.SetActive(true);
    }
}
  void RotateCharacter() {
    float horizontalSpeed = 3f;
    float h = horizontalSpeed * Input.GetAxis("Mouse X");
    transform.Rotate(0, h, 0);
  }
  }
/*import React, { useEffect, useState } from 'react';
import './style.css';

export default function App() {
  const [pokemons, setPokemons] = useState([]);
  const [loading, setLoading] = useState(true);

  const deletePokemon = (n) => {
    const deletedPokemons = pokemons.filter((p) => p.name !== n);
    setPokemons(deletedPokemons);
  };
  useEffect(() => {
    fetch(`https://pokeapi.co/api/v2/ability/?limit=20&offset=20`).then(
      (results) => {
        results.json().then((results) => {
          setPokemons(results.results.slice());
          setLoading(false);
        });
      }
    );
  }, []);

  return (
    <div>
      { !loading ?
        pokemons.length > 0 ? pokemons.map((p) => (
          <div onClick={() => deletePokemon(p.name)}>{p.name}</div>
        )) : <h2>No pokemons available</h2>
       : 
        <h2> Loading.. </h2>
      }
    </div>
  );
}
 */