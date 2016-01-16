using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Text testOut;

	public float speed;
	public float JumpSpeed;


	int colorId;
    public string playerColor;
    Renderer rend;


	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;

        colorId = 0;
        rend = GetComponent<Renderer>();

        
	}

	
	void ChangePlayerColor(string strcolor = "notSpecified") {
        switch (strcolor) {
            case "notSpecified":
                //Change the color based in the sequence
                NextColor();
                break;
            
        }
    }

    void NextColor() {
        print("nextColor");
        Color color = Color.black;

        colorId++;
        if (colorId > 2) {
            colorId = 0;
        }
        switch (colorId) {
            case 0:
                color = Color.red;
                playerColor = "red";
                break;
            case 1:
                color = Color.green;
                playerColor = "green";
                break;
            case 2:
                color = Color.blue;
                playerColor = "blue";
                break;
        }
        rend.material.color = color;

    }


	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown ("space")){

			Jump();
		}
	 	if (Input.GetKeyDown(KeyCode.LeftControl)) {
            print("left control button pressed");
            //Get the material
            //Change the Color
            ChangePlayerColor();
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
		Rigidbody rb = GetComponent<Rigidbody>();
		Vector3 moveVector = rb.velocity;
		moveVector.y = JumpSpeed;
		rb.velocity = moveVector;
	}



	void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("wall"))
		{
			if (playerColor == other.gameObject.GetComponent<WallColor>().wallColor)
			{
				other.gameObject.GetComponent<MeshCollider>().isTrigger = true;
			} else {

				other.gameObject.GetComponent<MeshCollider>().isTrigger = false;
			}

		}else if (other.gameObject.CompareTag("enemy"))
		{
			if (playerColor == other.gameObject.GetComponent<EnemyColor>().enemyColor)
			{

				testOut.text = "You are a WinRar!";
				//gameOver();
			}
		}
    }

}
