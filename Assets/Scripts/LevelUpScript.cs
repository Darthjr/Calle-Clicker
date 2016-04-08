using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class LevelUpScript : MonoBehaviour {

	public int level = 1;
	public int xp = 1;
	public int limit = 10;
	public List<Sprite> faces = new List<Sprite> (); 
	public List<string> levelRank = new List<string> (); 
	public UnityEngine.UI.Text levelDisplay;
	public GameObject mLady;

	public Image kalleSprite;
	public Image xpBar;

	void Start (){
		xpBar.fillAmount = 0.0f;
		mLady.SetActive (false);
	}

	void Update(){
		if (levelRank.Count >= level) {
			levelDisplay.text = levelRank [level - 1];
		}
		if (level == 10) 
		{
			mLady.SetActive (true);
		}
	}

	public void addXp(){
		xp++;
		xpBar.fillAmount = ((float)xp / (float)limit);

		if(xp >= limit)
		{
			level++;
			xp = 0;
			limit *= 2;
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			if(faces.Count >= level)
			{
				kalleSprite.sprite = faces [level - 1];
			}
		}
	}
}
