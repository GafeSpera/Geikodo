using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearJudge : MonoBehaviour {

	public GameObject Line;
	private bool clear;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 LinePos = Line.transform.position;

		if (Input.GetKey (KeyCode.A) && LinePos.x >= -4.5 && LinePos.x <= -4) {
			clear = true;
			Debug.Log ("クリアー");
		}
	}
}
