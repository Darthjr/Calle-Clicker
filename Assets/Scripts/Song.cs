using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Song : MonoBehaviour {

    public bool isReagge = false;

    public LevelUpScript reaggeTime;

    public Sprite reaggeSprite;
    public Image kalleSprite;

    public AudioSource påSpången;
    public AudioSource reagge;


    void Start() {
        AudioSource audio = påSpången;
		audio.Play ();
        reagge.mute = true;
	}

    public void CallePåReagge()
    {
        if (isReagge == false) {
            påSpången.mute = true;
            reagge.mute = false;
            StartCoroutine(ReaggeTime());
            reaggeTime.reaggeCalleTime = true;

            kalleSprite.sprite = reaggeSprite;

            isReagge = true;
        }
    }

    public IEnumerator ReaggeTime()
    {
        yield return new WaitForSeconds(188);
        reagge.mute = true;
        påSpången.mute = false;
        isReagge = false;
        reaggeTime.reaggeCalleTime = false;
    }


}