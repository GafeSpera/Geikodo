using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonUI : MonoBehaviour{

	private float trSpeed = 1;
	private float scaleSpeed = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0,trSpeed*Time.deltaTime,0);
		transform.localScale += new Vector3(scaleSpeed*Time.deltaTime, scaleSpeed*Time.deltaTime, 0);
	}
}
