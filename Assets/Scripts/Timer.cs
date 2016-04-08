using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	private bool finished = false;
	public Highscore highscore;
	public Menu Changelvl;

	void Start () {
		startTime = Time.time;
		StartCoroutine (DelayTime ());
	}

	void Update () {
		if (finished == false) {
		float t = Time.time - startTime;

		string minutes = ((int) t / 60).ToString ();
		string seconds = (t % 60).ToString ("f1");

		timerText.text = minutes + ":" + seconds + " sec";

		if (minutes == "2") 
			{
				finished = true;
				timerText.color = Color.red;
				highscore.SetIsFinnished (true);

			}
		}
	}

	IEnumerator DelayTime()
	{
		yield return new WaitForSeconds (125);
		Debug.Log ("Chamge Scene");
		Changelvl.LeaveGame ("MainMenu");
	}
}
