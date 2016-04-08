using UnityEngine;
using System.Collections;

public class GnomesPerSec : MonoBehaviour {

	public UnityEngine.UI.Text gpsDisplay;
	public Click click;
	public ItemManager[] items;
	public Highscore giveScore;

	void Start(){
		StartCoroutine (AutoTick ());
	}

	void Update(){
		gpsDisplay.text = GetGnomesPerSec() + " Calle/sec";
	}

	public float GetGnomesPerSec(){
		float tick = 0;
		foreach (ItemManager item in items) {
			tick += item.count * item.tickValue;
		}
		return tick;
	}

	public void AutoGnomesPerSec (){
			click.gold += GetGnomesPerSec () / 10;
			giveScore.AddScore (GetGnomesPerSec () / 10);
		} 

	IEnumerator AutoTick(){
		while (true) {
			AutoGnomesPerSec();
			yield return new WaitForSeconds(0.10f);
		}
	}
}
