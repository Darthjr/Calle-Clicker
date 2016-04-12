using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

	public UnityEngine.UI.Text timedHighscore;
	public UnityEngine.UI.Text normalHighscore;
	public UnityEngine.UI.Text totalClicks;

	void Start()
	{
		timedHighscore.text = "Timed Highscore: " + KalleConverter.Instance.CurrencyIntoString (PlayerPrefs.GetFloat ("Highscore2", 0), false, false); 
		normalHighscore.text = "Normal Highscore: " + KalleConverter.Instance.CurrencyIntoString (PlayerPrefs.GetFloat ("Highscore1", 0), false, false);  
		totalClicks.text = "Total Clicks: " + KalleConverter.Instance.CurrencyIntoString (PlayerPrefs.GetFloat ("Clicks", 0), false, false);
	}
}