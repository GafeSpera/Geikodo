using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Onnpu_scr : MonoBehaviour {
	
	private AudioSource sound01;
	void Start () {
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];
	}
	

	void Update () {
		
	}


	public void OnTriggerStay2D(Collider2D obj){

		if (obj.CompareTag ("Player")) {
			if (Input.GetKeyDown (KeyCode.JoystickButton13)) {
				DestroyObj ();
				sound01.PlayOneShot(sound01.clip);
			} 
		}
	}


	void DestroyObj(){
		
		Destroy (gameObject);
		GameObject textmanager = GameObject.Find ("TextManager");
		textmanager.GetComponent<TextManager_scr> ().PulusPoint ();
	}
}