using UnityEngine;
using System.Collections;

public class MuteButton : MonoBehaviour {

	public bool isMute;

	void Start (){
		isMute = true;
	}

	public void Mute () {
		if (isMute) {
			AudioListener.pause = true;
			isMute = false;
		} else {
			AudioListener.pause = false;
			isMute = true;
		}
	}
}
