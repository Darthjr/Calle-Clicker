using UnityEngine;
using System.Collections;

public class SteroidUpgrade : MonoBehaviour {

    public bool enableCalle = false;
	public SpriteRenderer punchSprite;
    private float remaingTime;

    void Start()
    {
        punchSprite.enabled = false;
    }

	void Update () {
        remaingTime -= Time.deltaTime;
        Color fade = Color.white;
        fade.a = Mathf.Clamp01(remaingTime);
        punchSprite.color = fade;

        if (remaingTime < 0f)
        {
            punchSprite.enabled = false;
        }
	}

	public void spawnPunch()
	{
        if (enableCalle == true){
        punchSprite.enabled = true;

        //Transform Position
        Vector3 touchPosition = Input.mousePosition;
            if (Input.touchCount > 0)
            {
                touchPosition = Input.touches[0].position;
            }
            touchPosition.z = 0;


        punchSprite.transform.position = touchPosition;
        remaingTime = 2f;
        }
    }
}
//touches[0].position
