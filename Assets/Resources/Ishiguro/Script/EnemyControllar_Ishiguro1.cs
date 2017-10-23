using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControllar_Ishiguro1 : MonoBehaviour {

	private float X = 0;
	private float Y = -2;
	public int ang ;
	public float speed = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (X, Y);
			
		transform.rotation = Quaternion.Euler(0, 0, ang);

		if (X >= 2.6f) {
			ang = 90;
			Y-=speed;
		}else if (X <= -3) {
			ang = 270;
			Y+=speed;
		}

		if (Y >= 2) {
			ang = 180;
			X+= speed;
		}else if(Y <= -2){
			ang = 0;
			X-= speed;
		}
	}
}
