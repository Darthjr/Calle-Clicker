using UnityEngine;
using System.Collections;

public class TimedHighscore : MonoBehaviour {

	bool isFinnished = false;
	public UnityEngine.UI.Text scoreText;
	public UnityEngine.UI.Text timedHighscoreText;
	float score1 = 0f;
	float timedHighscore = 0f;

	void Start () 
	{
		timedHighscore = PlayerPrefs.GetFloat ("Highscore Timed", 0);

	}

	void Update () 
	{
		scoreText.text = "Score: " + (int)score1;
		timedHighscoreText.text = "Highscore: " + (int)timedHighscore;

	}

	public void SetIsFinnished(bool finished)
	{
		isFinnished = finished;
	}

	[ContextMenu("Clear Highscore")]
	void DebugClear()
	{
		PlayerPrefs.DeleteAll ();
	}

	public void AddScore1(float amount)
	{
		if (isFinnished == false) 
		{
			score1 += amount;

			NewScore (score1);
		}
	}

	void NewScore(float score)
	{
		if(score > timedHighscore)
		{
			PlayerPrefs.SetFloat ("Highscore", score);
			timedHighscore = score;
		}
	}
}