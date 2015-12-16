using UnityEngine;
using System.Collections;

public class RightFlipper : MonoBehaviour {
	public float targetAngle;
	public float springForce;
	public float damper;
	// Use this for initialization
	void Start () {
		HingeJoint hinge = GetComponent<HingeJoint> ();
		JointSpring hingeSpring = hinge.spring;
		hingeSpring.damper = damper;
		hingeSpring.spring = springForce;
		hinge.spring = hingeSpring;
		hinge.useSpring = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightShift))
		{
			HingeJoint hinge = GetComponent<HingeJoint>();
			JointSpring hingeSpring = hinge.spring;
			hingeSpring.targetPosition = targetAngle;
			hinge.spring = hingeSpring;
			hinge.useSpring = true;
		}
		else
		{
			HingeJoint hinge = GetComponent<HingeJoint>();
			JointSpring hingeSpring = hinge.spring;
			hingeSpring.targetPosition = 0;
			hinge.spring = hingeSpring;
			hinge.useSpring = true;
		}
	}
}
