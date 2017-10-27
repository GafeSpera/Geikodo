using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanniMove : MonoBehaviour
{
	public GameObject tanni;
	private Vector3 tanniPos;

	// Use this for initialization
	void Start (){
		tanniPos = tanni.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		tanni.transform.position = tanniPos;
		if (Input.GetKey(KeyCode.JoystickButton4)) {
			tanniPos.y += 0.2f;
		}
		if (Input.GetKey(KeyCode.JoystickButton6)) {
			tanniPos.y -= 0.2f;
		}
		if (Input.GetKey(KeyCode.JoystickButton5)) {
			tanniPos.x += 0.2f;
		}
		if (Input.GetKey(KeyCode.JoystickButton7)) {
			tanniPos.x -= 0.2f;
		}
		
		}
	}
