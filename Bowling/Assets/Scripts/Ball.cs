using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject cameraObject;
    public Vector3 finishPosition;
    public Vector3 finishRotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("pin")) {
            cameraObject.GetComponent<CameraFollow>().overrideFollow(finishPosition, Quaternion.Euler(finishRotation));
        }
    }
}
