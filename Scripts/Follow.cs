using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

  public float speed = 1f;
  // Start is called before the first frame update
  void Start() {
  }

  // Utilizar el eje “Horizontal” para girar el objetivo y que avance siempre en la dirección hacia adelante.
  // Ayuda: La dirección hacia adelante (eje Z positivo) se puede obtener con la propiedad fordward del Transform. No confundir con Vector3.fordward.
  // Update is called once per frame
  void Update() {
    transform.Rotate(0, Input.GetAxis("Horizontal") * speed, 0);
    transform.Translate(transform.forward * speed * Time.deltaTime, Space.World); // requires Space.World to move forward
    // transform.Translate(Vector3.forward * speed * Time.deltaTime);  // the direction is relative to the cube no need for Space.World
  }
}
