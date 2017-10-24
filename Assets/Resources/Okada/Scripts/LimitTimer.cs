using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LimitTimer : MonoBehaviour {

	public GameObject Failed;

	void Start () {
		Invoke ("LoadMiddleScene", 5.0f);

		if (GeikodoManager.isSuccess) {
			Failed.SetActive (false);
		}
		else {
			Failed.SetActive (true);
		}
	}
	
	// Update is called once per frame
	public void LoadMiddleScene () {
		SceneManager.LoadScene ("Main");
	}
}
