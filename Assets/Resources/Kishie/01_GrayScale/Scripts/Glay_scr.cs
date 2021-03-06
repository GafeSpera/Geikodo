﻿using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Glay_scr : MonoBehaviour {
	
	float x = 0;
	int t ;
	float speed = 2f;
	private GameObject came = null;
	private Camera cs;
	bool zoom;
	public GameObject GameClear;
	public GameObject GameOver;
	public float Level = 1f;
	private float defaultCameraScale =  2.929865f;

	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip>();

	void Start () {
		GeikodoManager.isSuccess = false;
		came = GameObject.Find ("Main Camera");
		cs = came.GetComponent<Camera> ();
		cs.orthographicSize = defaultCameraScale;
		audioSource = GetComponent<AudioSource> ();
	}


	void Update () {
		Move ();
		if (this.transform.position.x >= 7) {
			x = -7;
		}
		if (Input.GetKeyDown (KeyCode.JoystickButton13)){
			Stop();
		}
		if(zoom){
			ZoomOut ();
		}
	}

	public void Move(){
		Vector2 Move = new Vector2 (x,-0.22f);
		this.transform.position = Move;
		t ++;
		if(t >= 8 - Level){
			x += speed;
			t = 0;
		}
	}

	public void Stop(){
		speed = 0;
		zoom = true;
		Invoke ("DisplayRezult",0.5f);
	}

	public void ZoomOut(){
		cs.orthographicSize += 0.2f;
		if (cs.orthographicSize >= 8.00f) {
			cs.orthographicSize = 8.00f;
		}
	}

	public void DisplayRezult(){
		if (x == -1) {
			//Debug.Log ("ok");
			GameClear.SetActive (true);
			audioSource.PlayOneShot (audioClip[0]);
			GeikodoManager.isSuccess = true;
		} else {
			//Debug.Log ("再提出");
			GameOver.SetActive (true);
			audioSource.PlayOneShot (audioClip[1]);
		}
	}
}

