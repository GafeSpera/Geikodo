using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	public Renderer rend;

	// Use this for initialization
	void Start () {
//		this.gameObject.SetActive (false);
		rend = GetComponent<Renderer>();
		rend.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (ClearJudge.clear) {
//			this.gameObject.SetActive (true);
			rend.enabled = true;
		}
	}
}
