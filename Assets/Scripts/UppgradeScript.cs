using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UppgradeScript : MonoBehaviour {

	public Click click;

    public bool isSwipe = true;

    public UnityEngine.UI.Text itemInfo;

    public float cost2;

    public int count = 0;
	public int clickPower;

    public string itemName;
	public string identifer;

    public Color standard;
	public Color affordable;

    private Slider fillSlider;

	private float baseCost;

	void Start() {
        isSwipe = true;
        baseCost = cost2;
		fillSlider = GetComponentInChildren<Slider> ();

        if (Application.loadedLevel != 2) {
			cost2 = PlayerPrefs.GetFloat ("saveCost2Upgrade" + identifer.ToString(), cost2);
			count = PlayerPrefs.GetInt ("saveCountUpgrade" + identifer.ToString(), count);

		}
	}

	void Update() {

        if (isSwipe == true)
        {
            itemInfo.text = itemName + "\n" + "\n" + "\n";
            if (identifer == "5") 
            {
                itemInfo.text = "\n" + itemName;
            }
        }

        if (isSwipe == false) { 
		itemInfo.text = itemName + "\nCost: " + KalleConverter.Instance.CurrencyIntoString(cost2, false, true) + "\nClicks: +" + clickPower;
        }

        fillSlider.value = click.gold / cost2 * 100;
		if (fillSlider.value >= 100) {
			GetComponent<Image> ().color = affordable;
		} else {
			GetComponent<Image> ().color = standard;
		}
	}

	public void PurchasedUpgrade() {
		if (click.gold >= cost2) {
			click.gold -= cost2;
			count += 1;
			click.goldPerClick += clickPower;
			cost2 = Mathf.Round (baseCost * Mathf.Pow (1.80f, count));

			if (Application.loadedLevel != 2) {
				PlayerPrefs.SetFloat ("saveCost2Upgrade" + identifer.ToString (), cost2);
				PlayerPrefs.SetInt ("saveCountUpgrade" + identifer.ToString(), count);
			}
		}
	}
}