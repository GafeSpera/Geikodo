using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class player_scr: MonoBehaviour {
	public Vector2 SPEED = new Vector2(0.1f, 0.2f);
	bool move = true;
	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip>();
	public GameObject miss;

	void Start () {
		audioSource = GetComponent<AudioSource> ();
		GeikodoManager.isSuccess = true;
	}
		
	void Update () {
		if (move) {
			Move ();
		}
	}
		

	void OnTriggerEnter2D (Collider2D collision){
		if(collision.CompareTag("Fish")){
			Death ();
			move = false;
		}
		if (collision.CompareTag ("Goal")) {
			audioSource.PlayOneShot (audioClip[1]);
		}
	}
			

	public void Move(){
		Vector2 Position = transform.position;
		Position.y -= SPEED.y;
		if(Input.GetKeyDown (KeyCode.JoystickButton7)){
			Position.x -= SPEED.x;
		} else if(Input.GetKeyDown (KeyCode.JoystickButton5)){
			Position.x += SPEED.x;
		}
		transform.position = Position;
	}


	public void Death (){
		//Debug.Log ("GameOver");
		//Destroy (gameObject);
		GeikodoManager.isSuccess = false;
		audioSource.PlayOneShot (audioClip[0]);
		miss.SetActive(true);
	}
}