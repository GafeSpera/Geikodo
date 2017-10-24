using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajiMove : MonoBehaviour {

	public GameObject[] Aji = new GameObject[3];
	private Vector3[] AjiPos = new Vector3[3];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Aji.Length; i++) {
			AjiPos [i] = Aji [i].transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Aji.Length; i++) {
			Aji [i].transform.position = AjiPos [i];
			AjiPos [i].x -= 0.6f;
		}
	}
}
