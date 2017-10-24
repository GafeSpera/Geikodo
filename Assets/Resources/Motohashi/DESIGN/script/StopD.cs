using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			RollingD.Roll = 0;
		}
	}
}
