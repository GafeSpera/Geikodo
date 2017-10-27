using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetorisuManager_scr : MonoBehaviour {

	float ok;
	public GameObject clear;
	public GameObject next1;
	public GameObject next2;
	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip>();

	void Start () {
		audioSource = GetComponent<AudioSource> ();
		GeikodoManager.isSuccess = false;
	}
	

	void Update () {
		if(ok == 1f){
			next1.SetActive(false);
			next2.SetActive(true);
		}
		if(ok == 2f){
			clear.SetActive(true);
			next2.SetActive(false);
			GeikodoManager.isSuccess = true;
			audioSource.PlayOneShot (audioClip[0]);
			ok = 0f;
		}
	}


	public void OK(){
		ok++;
	}
}
