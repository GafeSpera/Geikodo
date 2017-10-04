using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LimitTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("LoadMiddleScene", 5.0f);
	}
	
	// Update is called once per frame
	public void LoadMiddleScene () {
		SceneManager.LoadScene ("Main");
	}
}
