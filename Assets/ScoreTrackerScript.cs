using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrackerScript : MonoBehaviour {
	public Text scoreText;
	private int score;
	
	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = "Score: " + score.ToString();
		SharedRefs.scoreTrackerScript = this;
	}

	public void incrementScore() {
		score++;
		scoreText.text = "Score: " + score.ToString();
	}
}
