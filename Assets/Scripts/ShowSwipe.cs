using UnityEngine;
using System.Collections;

public class ShowSwipe : MonoBehaviour {

    public bool enableSwipe = false;
    public SpriteRenderer swipeSprite;


    void Start () {
        swipeSprite.enabled = false;
	}

    public void EnableSwipe() {
        swipeSprite.enabled = true;
    }

    public void DisableSwipe() {
        swipeSprite.enabled = false;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
