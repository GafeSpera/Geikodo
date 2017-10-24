using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit_scr : MonoBehaviour {

	public GameObject units;
	public float Speed;
	float X;
	float Y;
	bool move = true;
	bool unit = false;


	void Start () {
		X = this.transform.position.x;
		Y = this.transform.position.y;
	}
	

	void Update () {
		if (move) {
			Move ();
		} else {
			if(unit){
				Invoke ("Delete",0.1f);
				Invoke ("Active",0.15f);
				Invoke ("Delete",0.2f);
				Invoke ("Active",0.25f);
				Invoke ("Destroy",0.35f);
			}
		}
	}


	void OnTriggerEnter2D (Collider2D collision){
		if (collision.CompareTag ("Finish")) {
			move = false;
		}
		if (collision.CompareTag ("Goal")) {
			unit = true;
		}
//		if (collision.CompareTag ("wall")) {
//			
//		}
	}


	void Move(){
		Y -= Speed;
		if(Input.GetKeyDown ("right")){
			X += 1.3f;
		}
		if(Input.GetKeyDown ("left")){
			X -= 1.3f;
		}
		this.transform.position = new Vector2 (X,Y);
	}


	void Delete(){
		units.SetActive (false);
		gameObject.SetActive (false);
	}

	void Active(){
		units.SetActive (true);
		gameObject.SetActive (true);
	}

	void Destroy(){
		
		Destroy (units);
		Destroy (gameObject);
	}
}
