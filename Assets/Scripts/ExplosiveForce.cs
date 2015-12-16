using UnityEngine;
using System.Collections;

public class ExplosiveForce : MonoBehaviour {
	public float radius;
	public float power;
	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "Player") {
			Vector3 explosionPosition = col.contacts[0].point;
			Collider[] colliders = Physics.OverlapSphere (explosionPosition, radius);
			foreach (Collider hit in colliders) {
				Rigidbody rb = hit.GetComponent<Rigidbody> ();
				if (rb != null) {
					rb.AddExplosionForce (power, explosionPosition, radius, 0f);
				}
			}
		}
	}
}
