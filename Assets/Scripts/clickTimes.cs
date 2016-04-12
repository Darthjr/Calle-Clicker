using UnityEngine;
using System.Collections;

public class clickTimes : MonoBehaviour {

	public UnityEngine.UI.Text totalClickText;
	public float totalClicks = 0f;
	public float clicks = 0f;

	void Start () 
	{
		totalClicks = PlayerPrefs.GetFloat ("Clicks", 0);
	}

	void Update ()
	{
		totalClickText.text = "Total Clicks: " + (int)totalClicks;
	}

	public void AddClick(float amount)
		{
			clicks += amount;

			NewClickScore (clicks);
		}
	
	void NewClickScore(float clicks)
	{
		if (clicks < totalClicks) {
			totalClicks++;
		}
		PlayerPrefs.SetFloat ("Clicks", totalClicks);
		if (clicks > totalClicks)
			totalClicks = clicks;
	}
}