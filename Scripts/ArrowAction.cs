using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAction : MonoBehaviour
{

  public float speed = 1f;
  private GameObject sphere;

  // Start is called before the first frame update
  void Start() {
    sphere = GameObject.FindGameObjectWithTag("Sphere");
  }

  // Update is called once per frame
  void Update() {
    if(Input.GetKey(KeyCode.UpArrow)) {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.DownArrow)) {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.LeftArrow)) {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.RightArrow)) {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    if(Input.GetKey(KeyCode.W)) {
        sphere.transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.S)) {
        sphere.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.A)) {
        sphere.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.D)) {
        sphere.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    // withoput time.deltatime, the objects moves too fast
    // if(Input.GetKey(KeyCode.UpArrow)) {
    //   transform.Translate(Vector3.up * speed);
    // }
    // if(Input.GetKey(KeyCode.DownArrow)) {
    //   transform.Translate(Vector3.down * speed);
    // }
    // if(Input.GetKey(KeyCode.LeftArrow)) {
    //   transform.Translate(Vector3.left * speed);
    // }
    // if(Input.GetKey(KeyCode.RightArrow)) {
    //   transform.Translate(Vector3.right * speed);
    // }

    // if (Input.GetKey(KeyCode.W)) {
    //   sphere.transform.Translate(Vector3.up * speed);
    // }
    // if (Input.GetKey(KeyCode.S)) {
    //   sphere.transform.Translate(Vector3.down * speed);
    // }
    // if (Input.GetKey(KeyCode.A)) {
    //   sphere.transform.Translate(Vector3.left * speed);
    // }
    // if (Input.GetKey(KeyCode.D)) {
    //   sphere.transform.Translate(Vector3.right * speed);
    // }

  }
}
