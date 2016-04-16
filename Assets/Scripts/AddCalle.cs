using UnityEngine;
using System.Collections;

public class AddCalle : MonoBehaviour {

	public Canvas canvas;
	public Animator calleAnim;

	string loadAnimation = "CalleAnim/Calle Circel";

	public Click clickGold;
	public ItemManager itemManager;

    private int calleCount;

	public Sprite calle;
	public GameObject callePref;

	void Start() {
        if (Application.loadedLevel != 2) {
            int count = PlayerPrefs.GetInt("Calle Count", 0);

            for (int c = 0; c < count; c++) {
            itemManager.spawncalle = true;
            addCalle();
            }
        }
    }

	public void addCalle() {
        if (Application.loadedLevel != 2) {
            if (itemManager.spawncalle == true) {

            calleCount++;

			//spawn Calle
			callePref = new GameObject ("CalleClone");

			//Render Calle Sprite
			SpriteRenderer renderer = callePref.AddComponent<SpriteRenderer> ();
			renderer.sprite = calle;

			//Ändra position
			callePref.transform.position = new Vector2 (624, 324);

			//Ändra storlek
			Vector3 scale = new Vector3 (0.1f, 0.09f, 1f);
			callePref.transform.localScale = scale;

			//Animations
			Animator anim = callePref.AddComponent<Animator> ();

			//calleAnim = GetComponent<Animator>();
			calleAnim = callePref.GetComponent<Animator> ();
			calleAnim.runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load (loadAnimation, typeof(RuntimeAnimatorController));
            calleAnim.Play("Cricle Around Calle", 0, Random.value);

			callePref.transform.SetParent (canvas.transform);

			//Reset
			itemManager.spawncalle = false;

            //PlayerPrefs
            PlayerPrefs.SetInt("Calle Count", calleCount);

		} else {
			return;
            }
        }
	}
}
