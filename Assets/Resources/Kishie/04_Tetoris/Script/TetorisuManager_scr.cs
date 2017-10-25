using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetorisuManager_scr : MonoBehaviour {

	float ok;
	public GameObject clear;
	public GameObject next1;
	public GameObject next2;

	void Start () {
		GeikodoManager.isSuccess = false;
	}
	

	void Update () {
		if(ok >= 1f){
			next1.SetActive(false);
			next2.SetActive(true);
		}
		if(ok >= 2f){
			clear.SetActive(true);
			next2.SetActive(false);
			GeikodoManager.isSuccess = true;
		}
	}


	public void OK(){
		ok++;
	}
}
