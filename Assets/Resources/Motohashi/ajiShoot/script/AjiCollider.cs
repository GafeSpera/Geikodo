using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjiCollider : MonoBehaviour {

//	public GameObject notAji;

	// Use this for initialization
	void Start () {
		GeikodoManager.isSuccess = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D Collision){
//		if (Collision.gameObject.tag == "aji") {
//			GeikodoManager.isSuccess = false;
//			Debug.Log ("ダメです");
//		}
		GeikodoManager.isSuccess = false;
		Debug.Log ("ダメです");
	}
}