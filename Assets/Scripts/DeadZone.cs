using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {
    GameObject spawn;
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("Respawn");
    }
	void OnTriggerEnter(Collider col)
    {
		if (col.tag == "Player") {
			BallManager.removeBall ();
			MoveBallBlock.Unblock ();
			col.transform.position = spawn.transform.position;
			Stop.ResetVelocity ();
		}
    }
}
