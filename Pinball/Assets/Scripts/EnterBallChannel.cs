using UnityEngine;
using System.Collections;

public class EnterBallChannel : MonoBehaviour {
    void OnTriggerEnter()
    {
        MoveBallBlock.Unblock();
    }
}
