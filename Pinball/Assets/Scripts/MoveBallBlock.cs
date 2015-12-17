using UnityEngine;
using System.Collections;

public class MoveBallBlock : MonoBehaviour {
    static GameObject block;
    static GameObject blockPosition;
    static GameObject resetPosition;
    void Start()
    {
        block = GameObject.FindGameObjectWithTag("Ball Block");
        blockPosition = GameObject.FindGameObjectWithTag("Ball Block Up");
        resetPosition = GameObject.FindGameObjectWithTag("Ball Block Reset");
    }
	public static void Block()
    {
        block.transform.position = blockPosition.transform.position;
    }

    public static void Unblock()
    {
        block.transform.position = resetPosition.transform.position;
    }
}
