using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour {

	public Sprite[] grades = new Sprite[5];
	private float time = 0;
	public string TitleScene = "Title";

	// Use this for initialization
	void Start () {
		int i = GeikodoManager.score / 2;
		if (i == 0) {
			GetComponent<RectTransform> ().sizeDelta += new Vector2 (50.0f, 0);
		}
		GetComponent<Image> ().sprite = grades [i];
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time >= 5.0f) {
			SceneManager.LoadScene (TitleScene);
		}
	}
}
