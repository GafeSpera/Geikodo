using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeikodoManager : MonoBehaviour {
    
    public static bool isSuccess = true;
    public static int score = 9;
    public static int currentSceneNumber = 1;
    float loadNextSceneSec = 2.75f;

	private float nextTime;
	private float gradesInterval = 0.1f;
	private bool on = false;

	public GameObject Failed;
	public GameObject Success;

	public GameObject[] grades = new GameObject[5];

	void Start () {
		nextTime = Time.time;
        StartCoroutine(LoadNextScene());
		Success.SetActive (isSuccess);
		Failed.SetActive (!isSuccess);
		if (isSuccess) {
			//do nothing
        }
        else {
            score--;
        }
		for (int i = 0; i < 5; i++) {
			grades [i].SetActive (i==score/2);
		}
        Debug.Log("SCORE: "+score);
    }

	void Update(){
		if (Time.time > nextTime) {
			grades [score/2].SetActive (!on);
			on = !on;
			nextTime += gradesInterval;
		}
	}

    private IEnumerator LoadNextScene() {
        yield return new WaitForSeconds(loadNextSceneSec);
        SceneManager.LoadScene(++currentSceneNumber);
    }
}