using UnityEngine;
using System.Collections;

public class KalleConverter : MonoBehaviour {

	private static KalleConverter instance;
	public static KalleConverter Instance{
		get{ 
			return instance;
		}
	}

	void Awake(){
		CreateInstance ();
	}

	void CreateInstance(){
		if (instance == null) {
			instance = this;
		}
	}

	public string CurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick){
		string converted;
		if (valueToConvert >= 1000000000) {
			converted = (valueToConvert / 1000000000f).ToString ("f1") + " Bil";
		
		} else if (valueToConvert >= 1000000) {
			converted = (valueToConvert / 1000000f).ToString ("f1") + " Mil";
		
		} else if(valueToConvert >= 1000){
			converted = (valueToConvert / 1000f).ToString ("f1") + " K";
		
		} else {
			converted = "" + valueToConvert.ToString ("f1");
		}

		if (currencyPerSec == true) {
			converted = converted;
		}

		if (currencyPerClick == true) {
			converted = converted;
		}
		return converted;
	}
}