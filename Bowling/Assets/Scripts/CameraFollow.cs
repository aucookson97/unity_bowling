using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject ball;
    public Vector3 offset;

    bool followingBall = true;

	// Use this for initialization
	void Start () {
        this.GetComponent<Transform>().position = ball.GetComponent<Transform>().position + offset;
    }

    // Update is called once per frame
    void Update () {
        if (followingBall)
        {
            this.GetComponent<Transform>().position = ball.GetComponent<Transform>().position + offset;
        }
	}

    public void overrideFollow(Vector3 pos, Quaternion rot)
    {
        followingBall = false;
        gameObject.GetComponent<Transform>().SetPositionAndRotation(pos, rot);
    }
}
