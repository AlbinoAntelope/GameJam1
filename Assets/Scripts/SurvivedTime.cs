using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SurvivedTime : MonoBehaviour {

	public float startTime = 0.0f;
	public Text timerText;
	public float currTime;
	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		currTime = startTime;
		timerText.text = "Survived Time: " + currTime.ToString ("F2");
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver) {
			currTime += Time.deltaTime;
			timerText.text = "Survived Time: " + currTime.ToString ("F2");
		}
	}
}
