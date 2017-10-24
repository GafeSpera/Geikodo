using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiCollider : MonoBehaviour {

//	public GameObject notAji;

	// Use this for initialization
	void Start () {
		GeikodoManager.isSuccess = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D Collision){
		GeikodoManager.isSuccess = false;
		Debug.Log ("ダメです");
	}
}