using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLine : MonoBehaviour {

	public static float a;
	public float speed;
	public GameObject blue;

	public Vector3 pos ;

	// Use this for initialization
	void Start () {
		
		a = 1;
	}
	
	// Update is called once per frame
	void Update () {
		pos = blue.transform.position;
		if (pos.x >= 6.5f) {
			a = -1;
		} 
		if (pos.x <= -6.5f) {
			a = 1;
		}

		this.transform.position += new Vector3 (a * speed, 0, 0);

	}
}
