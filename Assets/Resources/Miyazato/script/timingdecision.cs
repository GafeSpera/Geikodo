using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timingdecision : MonoBehaviour {
	private bool Isclapping1;
	private bool Isclapping2;
	private bool Isclapping3;
	private bool Isclapping4;
	private bool Isclapping5;
	private bool Isbadclapping;
	float time;
	float decisiontime;
	// Use this for initialization
	//各変数を初期化
	void Start () {
		GeikodoManager.isSuccess=true;
		time = 0;
		decisiontime = 0;
		Isclapping1 = false;
		Isclapping2 = false;
		Isclapping3 = false;
		Isclapping4 = false;
		Isclapping5 = false;
		Isbadclapping = false;
	}
	
	// Update is called once per frame
	//時間経過でartistを動かす
	void Update () {
		time += Time.deltaTime;
		Artistcontroller a1 = GetComponent<Artistcontroller> ();
		MizunoADController m1 = GetComponent<MizunoADController> ();
		if(time<=2 && Input.GetKeyDown(KeyCode.Space)){
			Isbadclapping = true;
			a1.OverChange ();
			m1.GameOverSE ();
			GeikodoManager.isSuccess=false;
		}
		if (Isclapping1 == false && time >= 1) {
			a1.ArtistChange1 ();
			Isclapping1 = true;
			m1.Clap ();
		} else if (Isclapping2 == false && time >= 2) {
			a1.ArtistChange2 ();
			Isclapping2 = true;
			m1.Clap ();
		} else if (Isclapping3 == false && time >= 2.1f && Isbadclapping == false) {
			//プレイヤーがボタンを押すまでの時間を計測
			decisiontime += Time.deltaTime;
			//1秒以内に押せば続く。押さなければゲームオーバー
			if (decisiontime <= 2 && Input.GetKeyDown(KeyCode.Space)) {
				a1.PlayerChange ();
				Isclapping3 = true;
				m1.Clap ();
				//decisiontimeを初期化
				decisiontime = 0;
			}else if(decisiontime >= 2){
				a1.OverChange ();
				m1.GameOverSE ();
				GeikodoManager.isSuccess=false;
			}
		} else if (Isclapping4 == false && time >= 4.1f) {
			a1.ArtistChange3 ();
			Isclapping4 = true;
			m1.Clap ();
		} else if (Isclapping5 == false && time >= 5) {
			a1.ArtistChange4 ();
			Isclapping5 = true;
			m1.Clap ();
		} else if (time >= 6) {
			//プレイヤーが成功していたなら続く。失敗していたら終了
			if (Isclapping3 == true) {
				a1.ArtistsInitialize ();
				Isclapping1 = false;
				Isclapping2 = false;
				Isclapping3 = false;
				Isclapping4 = false;
				Isclapping5 = false;
				time = 0;
			}
		}
	}
}
