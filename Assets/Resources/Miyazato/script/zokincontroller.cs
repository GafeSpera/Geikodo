using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zokincontroller : MonoBehaviour {
	private Vector2 pos;
	private int yasuricount;
	private int isright;
	private bool fanfale;
	AudioSource audioSource;
	public List<AudioClip> audioClip = new List<AudioClip> ();
	public GameObject yasuri;
	public GameObject uretan1;
	public GameObject uretan2;
	public GameObject uretan3;
	public GameObject uretan4;
	public GameObject star1;
	public GameObject star2;
	public GameObject endCanvas;

	// zokincount、isrightを初期化
	//zokinのpositionを取得
	void Start () {
		GeikodoManager.isSuccess = false;
		pos = yasuri.gameObject.transform.position;
		audioSource = GetComponent<AudioSource> ();
		fanfale = true;
		yasuricount = 0;
		isright = 0;
	}

	// ゲームのクリア判定
	// 雑巾の移動
	void Update () {
		KeyCount ();
		//zokincountが10未満なら雑巾を動かすことができる
		if (yasuricount < 5) {
			uretan1.gameObject.SetActive (true);
		}else if(yasuricount < 10){
			uretan1.gameObject.SetActive (false);
			uretan2.gameObject.SetActive (true);
		}else if (yasuricount< 15){
			uretan2.gameObject.SetActive (false);
			uretan3.gameObject.SetActive (true);
		}else if(yasuricount >= 20){
			yasuri.gameObject.SetActive (false);
			uretan3.gameObject.SetActive (false);
			uretan4.gameObject.SetActive (true);
			star1.gameObject.SetActive (true);
			star2.gameObject.SetActive (true);
			GeikodoManager.isSuccess = true;
			if(fanfale){
				audioSource.PlayOneShot (audioClip[1]);
				fanfale = false;
			}
		}
	}

	//キーが押された回数を数える
	void KeyCount () {
		if(yasuricount<20){
			//  雑巾が左にあるとき右を押すと移動する
			if (isright == 0) {
				if (Input.GetKeyDown (KeyCode.JoystickButton5)) {
					yasuricount++;
					IsRight ();
					pos.x += 5;
					yasuri.gameObject.transform.position = pos;
					audioSource.PlayOneShot (audioClip[0]);
				}
				//  雑巾が右にあるとき左を押すと移動する
			} else if (isright == 1) {
				if (Input.GetKeyDown(KeyCode.JoystickButton7)) {
					yasuricount++;
					IsLeft ();
					pos.x -= 5;
					yasuri.gameObject.transform.position = pos;
					audioSource.PlayOneShot (audioClip[0]);
				}
			}
		}
	}

	//右が押されたらプラス
	void IsRight () {
		isright += 1;
	}

	//左が押されたマイナス
	void IsLeft () {
		isright -= 1;
	}
}
