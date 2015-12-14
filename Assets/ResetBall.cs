using UnityEngine;
using System.Collections;

public class ResetBall : MonoBehaviour {
    GameObject spawn;
    GameObject ball;
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("Respawn");
        ball = GameObject.FindGameObjectWithTag("Player");
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            MoveBallBlock.Unblock();
            ball.transform.position = spawn.transform.position;
            Stop.ResetVelocity();
        }
    }
}
