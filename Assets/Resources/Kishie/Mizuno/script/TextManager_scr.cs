using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class TextManager_scr : MonoBehaviour {

	public GameObject GameStart;
	public GameObject GameCleare;
	public GameObject GameOver;
	float t = 0f;
	float num_of_onnpu = 10f;
	float Point;
	bool result = false;

	void Start () {
		GeikodoManager.isSuccess = false;
	}


	void Update () {
		GamsStart ();
		if (result) {
			Result ();
		}

	}


	void GamsStart(){
		t++;
		if(t>=60f){
			GameStart.SetActive (false);
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
			//GameOver.SetActive (true);
		}
	}
}
