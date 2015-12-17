using UnityEngine;
using System.Collections;

public class GivePoints : MonoBehaviour {
	public int points;
	public void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			ScoreManager.UpdateScore (points);
		}
	}

	public void OnCollisionEnter(Collision col){
		if(col.collider.tag == "Player") {
			ScoreManager.UpdateScore (points);
		}
	}
}
