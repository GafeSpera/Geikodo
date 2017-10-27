using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearJudge : MonoBehaviour {

	public GameObject Line;
	public static bool clear;

	// Use this for initialization
	void Start () {
		GeikodoManager.isSuccess = false;
		clear = false;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 LinePos = Line.transform.position;

		if (Input.GetKey (KeyCode.Space) && LinePos.x >= -4.5 && LinePos.x <= -4) {
			clear = true;
			Debug.Log ("YEEEEEEE");
			GeikodoManager.isSuccess = true;
		}
	}
}
