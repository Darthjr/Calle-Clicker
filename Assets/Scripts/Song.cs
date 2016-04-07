using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Song : MonoBehaviour {

	public LevelUpScript levelupSound;

	void Start() {
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		audio.Play(44100);
	}
}