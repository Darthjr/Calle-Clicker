using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

	public UnityEngine.UI.Text itemInfo;

	public Click click;

	public float cost;
	public int tickValue;
	public int count;
	public string itemName;
	private float baseCost;
	public string identifer;

	public Color standard;
	public Color affordable;

	private Slider fillSlider;

	void Start (){
		baseCost = cost;
		fillSlider = GetComponentInChildren<Slider> ();

		// Don't enter here if it's timed level (scene 2)
		if (Application.loadedLevel != 2) {

			cost = PlayerPrefs.GetFloat ("savedCost" + identifer.ToString(), cost);
			count = PlayerPrefs.GetInt ("savedCount" + identifer.ToString(), count);
		}
	}

	void Update(){
		itemInfo.text = itemName + "\nCost " + KalleConverter.Instance.CurrencyIntoString(cost, true, false) + "\nCalle; " + tickValue + "/s";

		fillSlider.value = click.gold / cost * 100;
		if (fillSlider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}

	public void PurchasedItem() {
		if (click.gold >= cost) {
			click.gold -= cost;
			count++;
			cost = Mathf.Round (baseCost * Mathf.Pow(1.75f, count));
			if (Application.loadedLevel != 2) {
				PlayerPrefs.SetFloat ("savedCost" + identifer.ToString (), cost);
				PlayerPrefs.SetInt ("savedCount" + identifer.ToString (), count);
			}
		}
	}
}