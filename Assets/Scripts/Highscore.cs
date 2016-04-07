using UnityEngine;
using System.Collections;

public class Highscore : MonoBehaviour {

	bool isFinnished = false;
	public UnityEngine.UI.Text highscoreText;
	public UnityEngine.UI.Text scoreText;
	float highscore = 0f;
	float score = 0f;

	void Start () 
	{
		highscore = PlayerPrefs.GetFloat ("Highscore", 0);
	}

	void Update () 
	{
		highscoreText.text = "Highscore: " + (int) highscore;
		scoreText.text = "Score: " + (int)score;
	
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

	public void AddScore(float amount)
	{
		if (isFinnished == false) 
		{
			score += amount;

			NewScore (score);
		}
	}

	void NewScore(float score)
	{
		if(score > highscore)
		{
			PlayerPrefs.SetFloat ("Highscore", score);
			highscore = score;
		}
	}
}
