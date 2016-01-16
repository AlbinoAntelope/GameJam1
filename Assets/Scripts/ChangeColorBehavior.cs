using UnityEngine;
using System.Collections;

public class ChangeColorBehavior : MonoBehaviour {

    string currentColor;
    string[] colorOptions = { "red", "green", "blue" };
    int colorId;

    Renderer rend;

	// Use this for initialization
	void Start () {
        colorId = 0;
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            print("left control button pressed");
            //Get the material
            //Change the Color
            ChangePlayerColor();
        }
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
                break;
            case 1:
                color = Color.green;
                break;
            case 2:
                color = Color.blue;
                break;
        }
        rend.material.color = color;

    }



}
