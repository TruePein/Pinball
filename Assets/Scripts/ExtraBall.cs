using UnityEngine;
using System.Collections;

public class ExtraBall : MonoBehaviour {
	private bool colliding;
	private int balls;
	public GameObject extraBall;
	public void Start(){
		colliding = false;
	}
	public void OnTriggerEnter(Collider col){
		if (col.tag == "Player" || col.tag == "Extra") {
			balls++;
			if(!colliding){
				colliding = true;
				BallManager.addBall();
				BallManager.addBall();
				Instantiate(extraBall);
			}
		}
	}
	public void OnTriggerExit(Collider col){
		if (col.tag == "Player" || col.tag == "Extra") {
			balls--;
		}
		if (balls == 0) {
			colliding = false;
		}
	}
}
