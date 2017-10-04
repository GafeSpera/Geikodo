using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class player_scr: MonoBehaviour {
	public Vector2 SPEED = new Vector2(0.1f, 0.2f);
	bool move = true;
	//private GameObject came = null;
	//private Camera cs;
	//private float defaultCameraScale = 10f;
	//bool zoom = false;

	void Start () {
		//GeikodoManager.isSuccess = false;
//		came = GameObject.Find ("Main Camera");
//		cs = came.GetComponent<Camera> ();
//		cs.orthographicSize = defaultCameraScale;
	}
		
	void Update () {
		if (move) {
			Move ();
		}
//		if(zoom){
//			ZoomIn ();
//		}
	}
		

	void OnTriggerEnter2D (Collider2D collision){
		//zoom = true;
		if(collision.CompareTag("Fish")){
			Invoke ("Death",1f);
			move = false;
		}
		if (collision.CompareTag ("Goal")) {
			
		}
	}
			

	public void Move(){
		Vector2 Position = transform.position;
		Position.y -= SPEED.y;
		if(Input.GetKey("left")){
			Position.x -= SPEED.x;
		} else if(Input.GetKey("right")){
			Position.x += SPEED.x;
		}
		transform.position = Position;
	}


	public void Death (){
		Debug.Log ("GameOver");
		//Destroy (gameObject);
	}


	public void ZoomIn(){
		

		//cs.orthographicSize -= 0.2f;
//		if (cs.orthographicSize <= 2.0f) {
//			cs.orthographicSize = 2.0f;
//		}
	}
}