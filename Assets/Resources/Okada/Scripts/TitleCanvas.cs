using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleCanvas : MonoBehaviour {

	public GameObject PAKui;
	public bool on = false;
	private float nextTime;
	public float interval = 1.0f;
	// Use this for initialization
	void Start () {
		nextTime = Time.time;
		GeikodoManager.score = 9;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextTime) {
			PAKui.SetActive (!on);
			on = !on;
			nextTime += interval;
		}

		if (Input.GetKeyDown (KeyCode.L) || Input.GetKeyDown(KeyCode.JoystickButton13)) {
			SceneManager.LoadScene ("Main");
		}
	}
}
