using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour {
	public Camera cam ;
	private Vector3 campos;
	// Use this for initialization
	void Start () {
		campos = cam.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (StopD.Stoped == true) {
			if (cam.transform.position.x < 0) {
				cam.transform.position = campos;
				campos.x += 0.3f;
			}
			if (cam.orthographicSize < 5.4f) {
				cam.orthographicSize += 0.3f;
			}
		}
	}
}
