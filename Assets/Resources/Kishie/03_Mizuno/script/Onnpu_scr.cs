using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class Onnpu_scr : MonoBehaviour {
	

	void Start () {
		
	}
	

	void Update () {
		
	}


	public void OnTriggerStay2D(Collider2D obj){

		if (obj.CompareTag ("Player")) {
			if (Input.GetKeyDown ("space")) {
				DestroyObj ();
			} 
		}
	}


	void DestroyObj(){
		Destroy (gameObject);
		GameObject textmanager = GameObject.Find ("TextManager");
		textmanager.GetComponent<TextManager_scr> ().PulusPoint ();
	}
}