using UnityEngine;
using System.Collections;

public class ExtraBall : MonoBehaviour {

	public void OnTriggerEnter(Collider col){
		if (col.tag == "Player" || col.tag == "Extra") {

		}
	}
}
