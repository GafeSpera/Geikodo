using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MizunoADController : MonoBehaviour {
	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip>();

	void Start(){
		audioSource = GetComponent<AudioSource> ();
	}

	public void Clap(){
		audioSource.PlayOneShot (audioClip[0]);
	}

	public void GameOverSE(){
		audioSource.PlayOneShot (audioClip[1]);
	}
}
