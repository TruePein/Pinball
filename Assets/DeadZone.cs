using UnityEngine;
using System.Collections;

public class DeadZone : MonoBehaviour {
    GameObject spawn;
    GameObject ball;
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("Respawn");
        ball = GameObject.FindGameObjectWithTag("Player");
    }
	void OnTriggerEnter()
    {
        BallManager.removeBall();
        MoveBallBlock.Unblock();
        ball.transform.position = spawn.transform.position;
        Stop.ResetVelocity();
    }
}
