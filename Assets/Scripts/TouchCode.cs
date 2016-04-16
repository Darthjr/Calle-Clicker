using UnityEngine;
using System.Collections;

public class TouchCode : MonoBehaviour {

    public bool enableSwipe = false;

    public ShowSwipe showSwipe;
    public UppgradeScript upgrade;
    public ItemManager item;
    public UppgradeScript upgrade2;
    public ItemManager item2;
    public UppgradeScript upgrade3;
    public ItemManager item3;
    public UppgradeScript upgrade4;
    public ItemManager item4;
    public UppgradeScript upgrade5;
    public ItemManager item5;
    public UppgradeScript upgrade6;
    public ItemManager item6;
    public UppgradeScript upgrade7;
    public ItemManager item7;
    public UppgradeScript upgrade8;
    public ItemManager item8;

    public float minSwipeDistY;
	public float minSwipeDistX;

    public Sprite CalleSprit;
    public GameObject calleGameObj;

    private Vector2 startPos;

    public IEnumerator DelayIteminfo()
    {
        upgrade.isSwipe = false;
        upgrade2.isSwipe = false;
        upgrade3.isSwipe = false;
        upgrade4.isSwipe = false;
        upgrade5.isSwipe = false;
        upgrade6.isSwipe = false;
        upgrade7.isSwipe = false;
        upgrade8.isSwipe = false;
        yield return new WaitForSeconds(5);
        upgrade.isSwipe = true;
        upgrade2.isSwipe = true;
        upgrade3.isSwipe = true;
        upgrade4.isSwipe = true;
        upgrade5.isSwipe = true;
        upgrade6.isSwipe = true;
        upgrade7.isSwipe = true;
        upgrade8.isSwipe = true;
        yield return new WaitForSeconds(0);
        item.isSwipe2 = false;
        yield return new WaitForSeconds(0);
        item.isSwipe2 = true;
        item2.isSwipe2 = true;
        item3.isSwipe2 = true;
        item4.isSwipe2 = true;
        item5.isSwipe2 = true;
        item6.isSwipe2 = true;
        item7.isSwipe2 = true;
        item8.isSwipe2 = true;
        yield return new WaitForSeconds(1);
        enableSwipe = false;
    }

    void Update()
	{   
		//#if UNITY_ANDROID
		if (Input.touchCount > 0) {

            Touch touch = Input.touches[0];

			switch (touch.phase) {
			case TouchPhase.Began: 
				
				startPos = touch.position;
				break;

			case TouchPhase.Ended:
				
				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
				if (swipeDistHorizontal > minSwipeDistX) 
				{
					float swipeValue = Mathf.Sign(touch.position.x - startPos.x);
					if (swipeValue > 0) {//right swipe

                            if(enableSwipe == false) { 
                                showSwipe.DisableSwipe();
                                upgrade.isSwipe = false;
                                item.isSwipe2 = false;

                                upgrade2.isSwipe = false;
                                item2.isSwipe2 = false;

                                upgrade3.isSwipe = false;
                                item3.isSwipe2 = false;

                                upgrade4.isSwipe = false;
                                item4.isSwipe2 = false;

                                upgrade5.isSwipe = false;
                                item5.isSwipe2 = false;

                                upgrade6.isSwipe = false;
                                item6.isSwipe2 = false;

                                upgrade7.isSwipe = false;
                                item7.isSwipe2 = false;

                                upgrade8.isSwipe = false;
                                item8.isSwipe2 = false;

                                StartCoroutine(DelayIteminfo());

                                enableSwipe = true;
                            }

                            //Sätt Kod som gör så att texten eneblas här!

                            /* calleGameObj = new GameObject("CalleClone2");

                            //Render Calle Sprite
                            SpriteRenderer renderer = calleGameObj.AddComponent<SpriteRenderer>();
                            renderer.sprite = CalleSprit;

                            //Ändra position
                            calleGameObj.transform.position = new Vector2(624, 324);

                            //Ändra storlek
                            Vector3 scale = new Vector3(0.1f, 0.09f, 1f);
                            calleGameObj.transform.localScale = scale;
                            //MoveRight (); */

                        } else if (swipeValue < 0) {//left swipe

						//MoveLeft ();

					}
				}
				break;
			}
		}
	}
}