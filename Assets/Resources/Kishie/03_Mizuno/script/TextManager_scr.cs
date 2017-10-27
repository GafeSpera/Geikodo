using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class TextManager_scr : MonoBehaviour {


	public GameObject GameCleare;
	public GameObject GameOver;
	float t = 0f;
	float num_of_onnpu = 6f;
	float Point;
	bool result = false;

	void Start () {
		GeikodoManager.isSuccess = false;
	}


	void Update () {
		
		if (result) {
			Result ();
		}

	}
		


	public void PulusPoint(){
		Point++;
		result = true;
	}

	void Result(){
		if (Point >= num_of_onnpu) {
			GameCleare.SetActive (true);
			GeikodoManager.isSuccess = true;
		}else{
			GeikodoManager.isSuccess = false;
		}
	}
}
