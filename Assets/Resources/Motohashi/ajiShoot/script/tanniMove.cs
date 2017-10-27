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
		if (WiimoteBase.wiimote.Button.d_right) {
			tanniPos.y += 0.2f;
		}
		if (WiimoteBase.wiimote.Button.d_left) {
			tanniPos.y -= 0.2f;
		}
		if (WiimoteBase.wiimote.Button.d_down) {
			tanniPos.x += 0.2f;
		}
		if (WiimoteBase.wiimote.Button.d_up) {
			tanniPos.x -= 0.2f;
		}
		
		}
	}
