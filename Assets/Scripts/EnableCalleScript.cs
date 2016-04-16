using UnityEngine;
using System.Collections;

public class EnableCalleScript : MonoBehaviour {

    public SteroidUpgrade steroidEnable;

	public void EnableCalleSteriods()
    {
        steroidEnable.enableCalle = true;
        Debug.Log("Amen Jag Funkar också");
    }
}
