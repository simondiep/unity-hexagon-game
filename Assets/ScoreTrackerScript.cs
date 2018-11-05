using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrackerScript : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;
	private int score;
	
	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = "Score: " + score.ToString();
		int highScore = PlayerPrefs.GetInt("highScore", 0);
		highScoreText.text = "High Score: " + highScore.ToString();
		SharedRefs.scoreTrackerScript = this;
	}

	public void incrementScore() {
		score++;
		scoreText.text = "Score: " + score.ToString();
		int highScore = PlayerPrefs.GetInt("highScore", 0);
		if(highScore <= score)
		{
				PlayerPrefs.SetInt("highScore", score);
				highScoreText.text = "High Score: " + highScore.ToString();
		}
	}
}
