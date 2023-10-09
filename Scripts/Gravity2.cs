using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity2 : MonoBehaviour
{

  private GameObject sphere;
  public float speed = 1f;

  private Vector3 moveDirection = Vector3.zero;
  // Start is called before the first frame update
  void Start() {
    sphere = GameObject.FindGameObjectWithTag("Sphere");
  }

  // Update is called once per frame
  void Update() {
    moveDirection = sphere.transform.position - transform.position;
    transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World); // cube moves towards the sphere
    // transform.Translate(moveDirection.normalized * speed * Time.deltaTime); // cube moves around the sphere
    transform.LookAt(sphere.transform);
    Debug.DrawRay(transform.position, moveDirection.normalized, Color.red);
  }
}
