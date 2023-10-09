using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

  public GameObject obj;
  // Start is called before the first frame update
  void Start() {
    
  }

  // Update is called once per frame
  void Update() {
    transform.LookAt(obj.transform);
    transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y + 5, obj.transform.position.z - 5);
  }
}
