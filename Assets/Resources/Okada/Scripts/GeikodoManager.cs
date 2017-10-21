using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeikodoManager : MonoBehaviour {
    
    public static bool isSuccess = true;
    public static int score = 10;
    public static int currentSceneNumber = 1;
    float loadNextSceneSec = 2.75f;

	void Start () {
        StartCoroutine(LoadNextScene());
        if (isSuccess) {
            //do nothing
        }
        else {
            score--;
        }
        
        Debug.Log(score);
    }

    private IEnumerator LoadNextScene() {
        yield return new WaitForSeconds(loadNextSceneSec);
        SceneManager.LoadScene(currentSceneNumber++);
    }
}