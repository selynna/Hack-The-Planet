using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	
	void Start() {

	}

	void OnCollisionEnter(Collision collision) {
		foreach (ContactPoint contact in collision.contacts) {
			if(collision.gameObject.tag == "fruit") {
				Destroy(collision.gameObject);
			}
		}
	}
}
