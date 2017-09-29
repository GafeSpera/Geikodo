using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Glay_scr : MonoBehaviour {
	
	float x = 0;
	int t ;
	public float speed;
	private GameObject came = null;
	private Camera cs;
	bool zoom;
	public GameObject GameClear;
	public GameObject GameOver;
    public GameObject endCanvas;

	void Start () {
		came = GameObject.Find ("Main Camera");
		cs = came.GetComponent<Camera> ();
		cs.orthographicSize = 2.929865f;
	}

	void Update () {
		Move ();
		if (this.transform.position.x >= 7) {
			x = -7;
		}
		if (Input.GetKeyDown ("space")) {
			Stop();
		}
		if(zoom){
			ZoomOut ();
		}
	}

	public void Move(){
		Vector2 Move = new Vector2 (x,-0.22f);
		this.transform.position = Move;
		t++;
		if(t >= 3){
			x += speed ;
			t = 0;
		}
	}

	public void Stop(){
		speed = 0;
		zoom = true;
		if (x == -1) {
			Debug.Log ("合格");
            GeikodoManager.isSuccess = true;
		    GameClear.SetActive (true);//拡大されてから表示したい
		} else {
			Debug.Log ("再提出");
            GeikodoManager.isSuccess = false;
            GameOver.SetActive (true);
        }
        Invoke("LoadMainScene",2f);
	}

	public void ZoomOut(){
		cs.orthographicSize += 0.1f;
		if (cs.orthographicSize >= 6.00f) {
			cs.orthographicSize = 6.00f;
		}
	}

    public void LoadMainScene() {
        Instantiate(endCanvas);
        Invoke("Jikkou", 0.5f);
    }

    public void Jikkou() {
        SceneManager.LoadScene("Main");
    }
}
