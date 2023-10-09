using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour {

    public float speed = 1f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            Debug.Log("UpArrow: " + speed * Input.GetAxis("Vertical"));
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            Debug.Log("DownArrow: " + speed * Input.GetAxis("Vertical"));
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("LeftArrow: " + speed * Input.GetAxis("Horizontal"));
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            Debug.Log("RightArrow: " + speed * Input.GetAxis("Horizontal"));
        }
    }
}
