using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultController : MonoBehaviour {

	public Sprite[] grades = new Sprite[5];

	// Use this for initialization
	void Start () {
		int i = GeikodoManager.score / 2;
		if (i == 1) {
			GetComponent<RectTransform> ().sizeDelta += new Vector2 (50.0f, 0);
		}
		GetComponent<Image> ().sprite = grades [i];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
