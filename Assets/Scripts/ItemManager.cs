using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public float cost;
	public int tickValue;
	public int count;
	public string itemName;
	private float baseCost;

	void Start (){
		baseCost = cost;
	}

	void Update(){
		itemInfo.text = itemName + "\nCost " + KalleConverter.Instance.CurrencyIntoString(cost, true, false) + "\nCalle; " + tickValue + "/s";
	}

	public void PurchasedItem() {
		if (click.gold >= cost) {
			click.gold -= cost;
			count++;
			cost = Mathf.Round (baseCost * Mathf.Pow(1.50f, count));

		}

	}
}