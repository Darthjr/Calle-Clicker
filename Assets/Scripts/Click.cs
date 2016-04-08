using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text goldDisplay;
	public UnityEngine.UI.Text gpc;
	public float gold = 0.00f; 
	public int goldPerClick = 1;
	//public float clicks = 0f;
	//public float totalClicks = 0f;
	public ParticleSystem kalleParticle;
	public LevelUpScript levelUp;
	public LevelUpScript giveLevel;
	public Highscore giveScore;
	public clickTimes clicksTotal;



	void Start()
	{
		//totalClicks = PlayerPrefs.GetFloat ("Clicks", 0);
	}

	void Update() {
		goldDisplay.text = "Callar: " + KalleConverter.Instance.CurrencyIntoString (gold, false, false);
		gpc.text = KalleConverter.Instance.CurrencyIntoString(goldPerClick, false, true) + " Calle/click";

		if(Input.GetKeyDown ("x")) 
		{
			gold += 10000000000;
		}
	}

	public void Clicked(){
		gold += goldPerClick;

		kalleParticle.Play ();

		levelUp.addXp ();

		giveScore.AddScore (goldPerClick);

		clicksTotal.AddClick (goldPerClick);
	}
}