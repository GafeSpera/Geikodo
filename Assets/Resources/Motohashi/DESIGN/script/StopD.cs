using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopD : MonoBehaviour {

	public static bool Stoped;

	// Use this for initialization
	void Start () {
		Stoped = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A) || Input.GetKeyDown(KeyCode.JoystickButton13)) {
			RollingD.Roll = 0;
			Stoped = true;
		}
	}
}
