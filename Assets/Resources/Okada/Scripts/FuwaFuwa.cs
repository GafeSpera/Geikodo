using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuwaFuwa : MonoBehaviour {

	private float speed = 300;
	private float amplitude = 0.02f; // 振幅
	private float frameCnt = 0; // フレームカウント

	void FixedUpdate () {
		frameCnt += speed*Time.deltaTime;
		if( 10000 <= frameCnt ){
			frameCnt = 0;
		}
		if( 0 == frameCnt%2 ){
			// 上下に振動させる（ふわふわを表現）
			float posYSin = Mathf.Sin(2.0f*Mathf.PI*(float)(frameCnt%200)/(200.0f-1.0f));
			transform.localScale += new Vector3 (amplitude*posYSin, amplitude*posYSin, 0);
		}
	}
	/*
	public float amplitude = 0.01f;
	private int frameCnt = 0;

	void FixedUpdate () {
		frameCnt++;
		if (10000 <= frameCnt) {
			frameCnt = 0;
		}
		if (0 == frameCnt % 2) {
			//float posYSin = Mathf.Sin(2.0f*Mathf.PI*(float)(frameCnt%200)/(200.0-1.0f));
			transform.localScale += new Vector3 (amplitude*frameCnt, amplitude*frameCnt, 0);
		}
	}*/
}