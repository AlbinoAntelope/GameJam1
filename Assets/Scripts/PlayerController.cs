using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Text testOut;

	public float speed;
	public float JumpSpeed;
	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown ("space")){

			Jump();
		}
		 	
	}

	void FixedUpdate () {

		float moveHorizontal = speed;
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 moveVector = rb.velocity;
		moveVector.x = moveHorizontal;
		rb.velocity = moveVector;
	}

	void Jump () {
		testOut.text = "You are a WinRar!";
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 moveVector = rb.velocity;
		moveVector.y = JumpSpeed;
		rb.velocity = moveVector;
	}

}
