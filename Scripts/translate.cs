using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translate : MonoBehaviour
{

    public float speed = 1f;
    public Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start() {
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    // Update is called once per frame
    void Update() {
        // transform.Translate(moveDirection.normalized * speed); // zips out of the screeen
        transform.Translate(moveDirection.normalized * speed * Time.deltaTime); // moves constantly
    }
}
