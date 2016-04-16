using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class LevelUpScript : MonoBehaviour {

	public int level = 1;
	public float xp = 1;
	public float limit = 10f;
	public List<Sprite> faces = new List<Sprite> (); 
	public List<string> levelRank = new List<string> (); 
	public UnityEngine.UI.Text levelDisplay;
	public string identifer;
    public bool reaggeCalleTime = false;

	public float width = 320;
	public float height = 260;
	public Vector3 position = new Vector3 (10, 5, 0);

	public GameObject mLady;
	public Image kalleSprite;
	public Image xpBar;

	void Start (){
		xpBar.fillAmount = 0.0f;
		mLady.SetActive (false);
		if (Application.loadedLevel != 2) {
		xp = PlayerPrefs.GetFloat ("xp", xp);
		level = PlayerPrefs.GetInt ("level" + identifer.ToString(), level);
		limit = PlayerPrefs.GetFloat ("limit" + identifer.ToString(), limit);
		}
	}

	void Update(){
		if (levelRank.Count >= level) {
			levelDisplay.text = levelRank [level - 1];

            if (reaggeCalleTime == false){
            kalleSprite.sprite = faces [level - 1];
            }
        }
		if (level == 10) 
		{
			mLady.SetActive (true);
			Vector3 scale = new Vector3 (width, height, 1f);
			transform.localScale = scale;
		}
		PlayerPrefs.SetFloat ("xp", xp);
	}

	public void addXpPerSec()
	{
		xp += 0.01f;
		xpBar.fillAmount = ((float)xp / (float)limit);
	}

	public void addXp(){
		xp++;
		xpBar.fillAmount = ((float)xp / (float)limit);
		if (Application.loadedLevel != 2) {
		PlayerPrefs.SetFloat ("xp", xp);
		}

		if(xp >= limit)
		{
			level++;
			xp = 0;
			limit *= 1.75f;
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			if(faces.Count >= level)
			{
				kalleSprite.sprite = faces [level - 1];

			}
			if (Application.loadedLevel != 2) {
				PlayerPrefs.SetInt ("level" + identifer.ToString (), level);
				PlayerPrefs.SetFloat ("limit" + identifer.ToString (), limit);
			}
		}
	}
}