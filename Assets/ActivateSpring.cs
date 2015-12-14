using UnityEngine;
using System.Collections;

public class ActivateSpring : MonoBehaviour {
    public float xForce;
    public float yForce;
    public float zForce;
    Rigidbody platform;
	// Use this for initialization
	void Start () {
        platform = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("space"))
        {
            platform.AddForce(new Vector3(xForce, yForce, zForce));
        }
	}
}
