using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultController : MonoBehaviour {

	public Sprite[] grades = new Sprite[5];

	// Use this for initialization
	void Start () {
		GetComponent<Image> ().sprite = grades [GeikodoManager.score/2];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
