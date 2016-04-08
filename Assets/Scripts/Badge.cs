using UnityEngine;
using System.Collections;

public class Badge : MonoBehaviour {

	public bool setActive = false; 
	public GameObject secretBadge;

	void Start () {
		PlayerPrefs.GetInt ("showBadge", 0);
		secretBadge.SetActive (false);
	}
	
	public void SetActive(bool active)
	{
		setActive = active;
	}

	public void ActivateBadge()
	{
		if (setActive = false) {
			secretBadge.SetActive (false);
		} else {
			secretBadge.SetActive (true);
		}
	}

	void Update () {
		if (Application.loadedLevel == 3)
		{
			secretBadge.SetActive (true);
			setActive = true;
			PlayerPrefs.GetFloat ("showBadge", 0);
		}
	}


}