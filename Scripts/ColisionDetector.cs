using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColisionDetector : MonoBehaviour {

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  void OnCollisionEnter(Collision collision) {
    Debug.Log("Collision with: " + collision.gameObject.name);
  }
}
