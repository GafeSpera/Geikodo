using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit_scr : MonoBehaviour {

	public GameObject units;
	public	GameObject manager;
	public float Speed;
	private AudioSource sound01;
	private float X;
	private float Y;
	private float width = 1.3f;
	private bool move = true;
	private bool unit = false;

	void Start () {
		X = this.transform.position.x;
		Y = this.transform.position.y;
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];
	}
	

	void Update () {
		if (move) {
			Move ();
		} else {
			
			if(unit){
				Invoke ("Delete",0.10f);
				Invoke ("Active",0.15f);
				Invoke ("Delete",0.20f);
				Invoke ("Active",0.25f);
				Invoke ("Destroy",0.35f);
				unit = false;
			}
		}
	}


	void OnTriggerEnter2D (Collider2D collision){
		if (collision.CompareTag ("Finish")) {
			sound01.PlayOneShot(sound01.clip);
			move = false;
			this.transform.position = new Vector2 (X,Y);
		}
		if (collision.CompareTag ("Goal")) {
			unit = true;
		}
//		if (collision.CompareTag ("wall")) {
//			
//		}
	}


	public void Move(){
		Y -= Speed;
		if(Input.GetKeyDown ("right")){
			X += width;
		}
		if(Input.GetKeyDown ("left")){
			X -= width;
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
		manager.GetComponent<TetorisuManager_scr> ().OK();
	}
}
