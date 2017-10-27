using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSE : MonoBehaviour {

	float timer;
	public AudioSource audio;
	public AudioClip sound;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		if (timer == 20f) {
			audio.PlayOneShot (sound);
		}
		
	}
}
