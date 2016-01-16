using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverCollision : MonoBehaviour {

	public Text gameOverText;
	public SurvivedTime timerText;
	public Text commentText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.CompareTag("Player")) {
			Debug.Log ("Game over");
			Debug.Log ("GG", other);
			timerText.gameOver = true;
			gameOverText.text = "You survived " + timerText.currTime.ToString("F2") + " seconds!";
			string comment;
			if (timerText.currTime < 5) {
				comment = "You suck!";
			} else if (timerText.currTime >= 5 && timerText.currTime < 10) {
				comment = "Not bad!";
			} else if (timerText.currTime >= 10 && timerText.currTime < 30) {
				comment = "Keep going!";
			} else {
				comment = "Almost!!";
			}
			commentText.text = comment;
		}
	}
}
