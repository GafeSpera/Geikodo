using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour {
	private float amplitude = 0.05f; // 振幅
	private int frameCnt = 0; // フレームカウント
	private float speed = 200;

	void Start(){
		frameCnt = (int)(Random.value * 100);
	}

	void Update () {
		frameCnt += (int)(speed*Time.deltaTime);
		if( 10000 <= frameCnt ){
			frameCnt = 0;
		}
		if( 0 == frameCnt%2 ){
			// 上下に振動させる（ふわふわを表現）
			float posYSin = Mathf.Sin(2.0f*Mathf.PI*(float)(frameCnt%200)/(200.0f-1.0f));
			transform.Translate(0, amplitude * posYSin, 0);
		}
	}
}
