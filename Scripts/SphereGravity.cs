using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGravity : MonoBehaviour
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
    transform.Translate(moveDirection.normalized * speed * Time.deltaTime);
  }
}
