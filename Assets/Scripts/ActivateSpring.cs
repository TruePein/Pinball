using UnityEngine;
using System.Collections;

public class ActivateSpring : MonoBehaviour {

	public float upforce;
	public float downForce;
	public float restZ;
	public float springZ;
	public float damper;
	// Use this for initialization
	void Start () {
		SpringJoint spring = GetComponent<SpringJoint> ();
		spring.damper = damper;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey ("space")) {
			SpringJoint spring = GetComponent<SpringJoint> ();
			Vector3 springAchor = spring.connectedAnchor;
			springAchor.z = springZ;
			spring.connectedAnchor = springAchor;
			spring.spring = downForce;
		} else {
			SpringJoint spring = GetComponent<SpringJoint> ();
			Vector3 springAchor = spring.connectedAnchor;
			springAchor.z = restZ;
			spring.connectedAnchor = springAchor;
			spring.spring = upforce;
		}
	}
}
