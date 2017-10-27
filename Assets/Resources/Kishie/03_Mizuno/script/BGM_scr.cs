using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_scr : MonoBehaviour {
	float timer;
	private AudioSource sound01;

	void Start () {
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];

	}
	
	// Update is called once per frame
	void Update () {
		
		timer++;
		if (timer == 60f) {
			sound01.PlayOneShot (sound01.clip);
			timer = 60f;
		}

	}
}
