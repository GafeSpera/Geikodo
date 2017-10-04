using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
public class GameStart_scr_Ebi : MonoBehaviour {

	public GameObject GameStart_Ebi;
	int t = 0;
	void Start () {

	}

	void Update () {
		t++;
		if(t>=60){
			GameStart_Ebi.SetActive (false);
		}

	}
}
