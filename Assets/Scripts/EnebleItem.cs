using UnityEngine;
using System.Collections;

public class EnebleItem : MonoBehaviour {

    public ShowSwipe showSwipe;
    public clickTimes goldEnable;
	public Click goldEnableGold;

    public bool oneTime = false;

	public int checkActive1 = 0;
	public int checkActive2 = 0;
	public int checkActive3 = 0;
	public int checkActive4 = 0;
	public int checkActive5 = 0;
	public int checkActive6 = 0;
	public int checkActive7 = 0;
	public int checkActive8 = 0;
	public int checkActive9 = 0;

	public int checkActiveUpgrade1 = 0;
	public int checkActiveUpgrade2 = 0;
	public int checkActiveUpgrade3 = 0;
	public int checkActiveUpgrade4 = 0;
	public int checkActiveUpgrade5 = 0;
	public int checkActiveUpgrade6 = 0;
	public int checkActiveUpgrade7 = 0;
	public int checkActiveUpgrade8 = 0;

	public GameObject item1;
	public GameObject item2;
	public GameObject item3;
	public GameObject item4;
	public GameObject item5;
	public GameObject item6;
	public GameObject item7;
	public GameObject item8;
	public GameObject item9;

	public GameObject Upgrade1;
	public GameObject Upgrade2;
	public GameObject Upgrade3;
	public GameObject Upgrade4;
	public GameObject Upgrade5;
	public GameObject Upgrade6;
	public GameObject Upgrade7;
	public GameObject Upgrade8;

	void Start () {
        if (Application.loadedLevel != 2) {
            item1.SetActive (false);
		item2.SetActive (false);
		item3.SetActive (false);
		item4.SetActive (false);
		item5.SetActive (false);
		item6.SetActive (false);
		item7.SetActive (false);
		item8.SetActive (false);
		item9.SetActive (false);

		Upgrade1.SetActive (false);
		Upgrade2.SetActive (false);
		Upgrade3.SetActive (false);
		Upgrade4.SetActive (false);
		Upgrade5.SetActive (false);
		Upgrade6.SetActive (false);
		Upgrade7.SetActive (false);
		Upgrade8.SetActive (false);
        }
    }

	void Update () {
        if (Application.loadedLevel != 2) {
            EnableItems ();
		CheckEnableItems ();
		CheckEnableItems2 ();
		CheckEnableItems3 ();
		CheckEnableItems4 ();
		CheckEnableItems5 ();
		CheckEnableItems6 ();
		CheckEnableItems7 ();
		CheckEnableItems8 ();
		CheckEnableItems9 ();

		EnableUpgrades ();
		CheckEnableUpgrades ();
		CheckEnableUpgrades2 ();
		CheckEnableUpgrades3 ();
		CheckEnableUpgrades4 ();
		CheckEnableUpgrades5 ();
		CheckEnableUpgrades6 ();
		CheckEnableUpgrades7 ();
		CheckEnableUpgrades8 ();
        }
    }

	public void EnableItems() {
        if (Application.loadedLevel != 2) {
            if (checkActive1 == 1) {
			item1.SetActive (true);

            if (oneTime == false) { 
            showSwipe.EnableSwipe();
                oneTime = true;
            }
        }
		if (checkActive2 == 1) {
			item2.SetActive (true);
		}
		if (checkActive3 == 1) {
			item3.SetActive (true);
		}
		if (checkActive4 == 1) {
			item4.SetActive (true);
		}
		if (checkActive5 == 1) {
			item5.SetActive (true);
		}
		if (checkActive6 == 1) {
			item6.SetActive (true);
		}
		if (checkActive7 == 1) {
			item7.SetActive (true);
		}
		if (checkActive8 == 1) {
			item8.SetActive (true);
		}
		if (checkActive9 == 1) {
			item9.SetActive (true);
            }
        }
	}


	public void CheckEnableItems (){
        if (goldEnable.totalClicks >= 5f) {
		    checkActive1 = 1;   
        }
	}
	public void CheckEnableItems2() {
		if (goldEnable.totalClicks >= 50f) {
			checkActive2 = 1;
		}
	}
	public void CheckEnableItems3(){
		if (goldEnable.totalClicks >= 200f) {
			checkActive3 = 1;
		}
	}
	public void CheckEnableItems4(){
		if (goldEnable.totalClicks >= 250f) {
			checkActive4 = 1;
		}
	}
	public void CheckEnableItems5(){
		if (goldEnable.totalClicks >= 550f) {
			checkActive5 = 1;
		}
	}
	public void CheckEnableItems6(){
		if (goldEnable.totalClicks >= 1000f) {
			checkActive6 = 1;
		}
	}
	public void CheckEnableItems7(){
		if (goldEnable.totalClicks >= 2000f) {
			checkActive7 = 1;
		}
	}
	public void CheckEnableItems8(){
		if (goldEnable.totalClicks >= 3000f) {
			checkActive8 = 1;
		}
	}
	public void CheckEnableItems9(){
		if (goldEnableGold.gold >= 100000f) {
			checkActive9 = 1;
		}
	}


	public void EnableUpgrades(){
		if (checkActiveUpgrade1 == 1) {
			Upgrade1.SetActive (true);
		}
		if (checkActiveUpgrade2 == 1) {
			Upgrade2.SetActive (true);
		}
		if (checkActiveUpgrade3 == 1) {
			Upgrade3.SetActive (true);
		}
		if (checkActiveUpgrade4 == 1) {
			Upgrade4.SetActive (true);
		}
		if (checkActiveUpgrade5 == 1) {
			Upgrade5.SetActive (true);
		}
		if (checkActiveUpgrade6 == 1) {
			Upgrade6.SetActive (true);
		}
		if (checkActiveUpgrade7 == 1) {
			Upgrade7.SetActive (true);
		}
		if (checkActiveUpgrade8 == 1) {
			Upgrade8.SetActive (true);
		}
	}

	public void CheckEnableUpgrades(){
		if (goldEnable.totalClicks >= 50f) {
			checkActiveUpgrade1 = 1;
		}
	}
	public void CheckEnableUpgrades2(){
		if (goldEnable.totalClicks >= 250f) {
			checkActiveUpgrade2 = 1;
		}
	}
	public void CheckEnableUpgrades3(){
		if (goldEnable.totalClicks >= 400f) {
			checkActiveUpgrade3 = 1;
		}
	}
	public void CheckEnableUpgrades4(){
		if (goldEnable.totalClicks >= 700f) {
			checkActiveUpgrade4 = 1;
		}
	}
	public void CheckEnableUpgrades5(){
		if (goldEnable.totalClicks >= 1500f) {
			checkActiveUpgrade5 = 1;
		}
	}
	public void CheckEnableUpgrades6(){
		if (goldEnable.totalClicks >= 2300f) {
			checkActiveUpgrade6 = 1;
		}
	}
	public void CheckEnableUpgrades7(){
		if (goldEnableGold.gold >= 800000f) {
			checkActiveUpgrade7 = 1;
		}
	}
	public void CheckEnableUpgrades8(){
		if (goldEnableGold.gold >= 1000000f) {
			checkActiveUpgrade8 = 1;
		}
	}
}