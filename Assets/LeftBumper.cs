using UnityEngine;
using System.Collections;

public class LeftBumper : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (GetComponent<Transform>().rotation.y > 330 || GetComponent<Rigidbody>().rotation.y < 18)
            {
                GetComponent<Rigidbody>().freezeRotation = false;
                GetComponent<Rigidbody>().AddTorque(0, -1f*speed, 0, ForceMode.Force);
            }
            else
            {
                GetComponent<Rigidbody>().freezeRotation = true;
            }
        }
        else
        {
            if(GetComponent<Transform>().rotation.y < 330 && GetComponent<Rigidbody>().rotation.y > 18)
            {
                GetComponent<Rigidbody>().freezeRotation = false;
                GetComponent<Rigidbody>().AddTorque(0, 1f * speed, 0, ForceMode.Force);
            }
            else
            {
                GetComponent<Rigidbody>().freezeRotation = true;
            }
        }
	}
}
