using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class GameStart_scr : MonoBehaviour {

	public GameObject GameStart;
	int t = 0;
	void Start () {
		
	}

	void Update () {
		t++;
		if(t>=60){
			GameStart.SetActive (false);
		}
		
	}
}
