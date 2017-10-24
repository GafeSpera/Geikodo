using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController_Ishiguro1 : MonoBehaviour {

	private Rigidbody2D rg2d;
	private float speed = 0.3f;
	public GameObject load;

	// Use this for initialization
	void Start () {
		GeikodoManager.isSuccess = false;
		rg2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		Time.fixedDeltaTime = 0.005f;
		Move();
	}

	void Move (){
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		Vector2 direction = new Vector2 (x, y).normalized;
		rg2d.position += direction * speed;
	}

	void OnTriggerEnter2D(Collider2D hit){
		if (hit.name == "light") {
			load.GetComponent<LimitTimer> ().LoadMiddleScene ();
		} else if (hit.name == "goal1" || hit.name == "goal2") {
			GeikodoManager.isSuccess = true;
		}
	}
		
}
