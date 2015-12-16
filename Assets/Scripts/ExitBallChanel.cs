using UnityEngine;
using System.Collections;

public class ExitBallChanel : MonoBehaviour {
	void OnTriggerEnter()
    {
        MoveBallBlock.Block();
    }
}
