using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LimitTimer : MonoBehaviour {

	public string startMassage = "しろ！";

	public GameObject Obj;
	public GameObject StartMassageObj;
	public GameObject Failed;
	public GameObject Success;

	private float startTime;
	private float interval = 1.0f;

	void Start () {
		Text StartMassageText;
		StartMassageText = StartMassageObj.GetComponent<Text> ();
		StartMassageText.text = startMassage;
		Obj.SetActive (true);
		startTime = Time.time;
		Invoke ("LoadMiddleScene", 5.0f);

		Success.SetActive (GeikodoManager.isSuccess);
		Failed.SetActive (!GeikodoManager.isSuccess);
	}

	void Update(){
		if (Time.time > startTime + interval) {
			Obj.SetActive(false);
		}
	}
	
	// Update is called once per frame
	public void LoadMiddleScene () {
		SceneManager.LoadScene ("Main");
	}
}
