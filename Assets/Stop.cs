using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {
    static Rigidbody ball;
	// Use this for initialization
	void Start () {
        ball = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	public static void ResetVelocity () {
        ball.velocity = Vector3.zero;
	}
}
