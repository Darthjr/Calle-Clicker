using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}

	public void LeaveGame(string leaveGame)
	{
		Application.LoadLevel (leaveGame);
	}
}