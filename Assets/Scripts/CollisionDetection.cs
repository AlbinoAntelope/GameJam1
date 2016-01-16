using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
		if (col.gameObject.tag == tag) {
			rb.detectCollisions = false;
			//Destroy (rb);
		} else {
			rb.detectCollisions = true;
		}
	}
	                   
}
