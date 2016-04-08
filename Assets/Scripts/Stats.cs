using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	public UnityEngine.UI.Text timedHighscore;
	public UnityEngine.UI.Text normalHighscore;
	public UnityEngine.UI.Text totalClicks;

	void Start()
	{
		timedHighscore.text = "Timed Highscore: " + PlayerPrefs.GetFloat ("Highscore2", 0).ToString();
		normalHighscore.text = "Normal Highscore: " + PlayerPrefs.GetFloat ("Highscore1", 0).ToString ();
		totalClicks.text = "Total Clicks: " + PlayerPrefs.GetFloat ("Clicks", 0).ToString ();
	}
}