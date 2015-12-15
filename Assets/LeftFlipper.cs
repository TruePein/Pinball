using UnityEngine;
using System.Collections;

public class LeftFlipper: MonoBehaviour {
    public float xRotationSpeed;
    public float yRotationSpeed;
    public float zRotationSpeed;
    public float maxXRotation;
    public float maxYRotation;
    public float maxZRotation;
    private float xRotation;
    private float yRotation;
    private float zRotation;
    // Use this for initialization
    void Start () {
        xRotation = 0f;
        yRotation = 0f;
        zRotation = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (xRotation < maxXRotation)
            {
                float x = GetComponent<Rigidbody>().rotation.x;
                GetComponent<Rigidbody>().AddTorque(xRotationSpeed, 0, 0);
                float newX = GetComponent<Rigidbody>().rotation.x - x;
                xRotation += newX;
            }
            if (yRotation < maxYRotation)
            {
                float y = GetComponent<Rigidbody>().rotation.y;
                GetComponent<Rigidbody>().AddTorque(0, yRotationSpeed, 0);
                float newY = GetComponent<Rigidbody>().rotation.y - y;
                xRotation += newY;
            }
            if (zRotation < maxZRotation)
            {
                float z = GetComponent<Rigidbody>().rotation.z;
                GetComponent<Rigidbody>().AddTorque(0, 0, zRotationSpeed);
                float newZ = GetComponent<Rigidbody>().rotation.z - z;
                xRotation += newZ;
            }
        }
        else
        {
            if (xRotation > 0)
            {
                float x = GetComponent<Rigidbody>().rotation.x;
                GetComponent<Rigidbody>().AddTorque(-xRotationSpeed, 0, 0);
                float newX = GetComponent<Rigidbody>().rotation.x - x;
                xRotation += newX;
            }
            if (yRotation >0)
            {
                float y = GetComponent<Rigidbody>().rotation.y;
                GetComponent<Rigidbody>().AddTorque(0, -yRotationSpeed, 0);
                float newY = GetComponent<Rigidbody>().rotation.y - y;
                xRotation += newY;
            }
            if (zRotation >0)
            {
                float z = GetComponent<Rigidbody>().rotation.z;
                GetComponent<Rigidbody>().AddTorque(0, 0, -zRotationSpeed);
                float newZ = GetComponent<Rigidbody>().rotation.z - z;
                xRotation += newZ;
            }
        }
	}
}
