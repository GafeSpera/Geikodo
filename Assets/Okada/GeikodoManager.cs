using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeikodoManager : MonoBehaviour {

    public static bool isSuccess = true;
    public static int score = 10;
    public static int currentSceneNumber = 0;
    public string[] Scenes;
    public float loadNextSceneSec = 3;

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadNextScene());
        if (isSuccess) {
            //score++; //do nothing
        }
        else {
            score--;
        }
        
        Debug.Log(score);
    }

    private IEnumerator LoadNextScene() {
        yield return new WaitForSeconds(loadNextSceneSec);
        SceneManager.LoadScene(Scenes[currentSceneNumber++]);
    }
}
