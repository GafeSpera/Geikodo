using UnityEngine;
using System.Collections;

public class player_scr: MonoBehaviour {
	public Vector2 SPEED = new Vector2(0.1f, 0.2f);

	void Start () {

	}
		
	void Update () {
		Move();
	}
		

	void OnTriggerEnter2D (Collider2D collision){
		
		//if(collision.gameObject.tag == "Fish"){
			Debug.Log ("GameOver");
		//} else if(collision.gameObject.tag == "Goal"){ 
		//	Debug.Log("GameClear");

		//}
	}

		        
			

	void Move(){
		Vector2 Position = transform.position;
		Position.y -= SPEED.y;
		if(Input.GetKey("left")){
			Position.x -= SPEED.x;
		} else if(Input.GetKey("right")){
			Position.x += SPEED.x;
		}
		transform.position = Position;
	}

}