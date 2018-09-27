using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject ball;
    public GameObject lane;
    public Vector3 force;
    public Vector3 torque;
    public float angularDrag;

	// Use this for initialization
	void Start () {
        // ball.GetComponent<Rigidbody>().velocity = new Vector3(-15.0f, 0.0f, 0.0f);
        lane.GetComponent<Rigidbody>().angularDrag = angularDrag;
        ball.GetComponent<Rigidbody>().angularDrag = angularDrag;
        ball.GetComponent<Rigidbody>().AddForce(force * 1000.0f);
        ball.GetComponent<Rigidbody>().AddTorque(torque * 1000.0f);
    }
	
	// Update is called once per frame
	void Update () {
        ball.GetComponent<Rigidbody>().AddTorque(torque * 1000.0f);
    }
}
