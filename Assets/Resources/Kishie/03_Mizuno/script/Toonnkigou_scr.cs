using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class  Toonnkigou_scr : MonoBehaviour {
	
	public GameObject Red;
	public float SpeedX;
	float X;
	float Y;

	void Start () {
		X = this.transform.position.y;
		Y = this.transform.position.y;
	}
	

	void Update () {
		Move ();
		if (Input.GetKeyDown ("space")) {
			Red.SetActive (true);
		} else {
			Red.SetActive (false);
		}
	}


	public void Move(){
		X += SpeedX;
		this.transform.position = new Vector2 (X,Y);
	}


}
