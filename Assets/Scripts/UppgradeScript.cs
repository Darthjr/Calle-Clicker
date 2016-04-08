using UnityEngine;
using System.Collections;

public class UppgradeScript : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
	private float baseCost;

	void Start() {
		baseCost = cost;
	}

	void Update() {
		itemInfo.text = itemName + "\nCost: " + KalleConverter.Instance.CurrencyIntoString(cost, false, true) + "\nClicks: +" + clickPower;
	}

	public void PurchasedUpgrade() {
		if (click.gold >= cost) {
			click.gold -= cost;
			count += 1;
			click.goldPerClick += clickPower;
			cost = Mathf.Round (baseCost * Mathf.Pow (1.60f, count));

		}
	}
}
