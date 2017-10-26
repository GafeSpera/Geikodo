using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeD : MonoBehaviour {

	public GameObject initialD;
	public Vector3 AngleD;

	// Use this for initialization
	void Start () {
		GeikodoManager.isSuccess = false;
		AngleD = initialD.transform.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		AngleD = initialD.transform.eulerAngles;
		if (StopD.Stoped == true) {
			if (AngleD.z<=15||AngleD.z>=345) {
				GeikodoManager.isSuccess = true;
				Debug.Log ("OK");
			} else {
				GeikodoManager.isSuccess = false;
				Debug.Log ("Miss");
			}
		}
	}
}
