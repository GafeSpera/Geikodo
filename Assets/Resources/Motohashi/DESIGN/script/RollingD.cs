using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingD : MonoBehaviour {

	public GameObject D;
	public static float Roll;

	// Use this for initialization
	void Start () {
		Roll = 5;
	}
	
	// Update is called once per frame
	void Update () {
		D.transform.Rotate (new Vector3 (0, 0, Roll));
	}
}
