using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeikodoManager : MonoBehaviour {
    
    public static bool isSuccess = true;
    public static int score = 10;
    public static int currentSceneNumber = 1;
    float loadNextSceneSec = 2.75f;

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
        SceneManager.LoadScene(currentSceneNumber++);
    }


	// うまく動かない
    public static void LoadMiddleScene() {
        Debug.Log("LoadMiddleScene called");
        GameObject uiObj = Resources.Load("Okada/Prefabs/SceneEndCanvas") as GameObject;
        Debug.Log(uiObj);
        Instantiate(uiObj, uiObj.transform);
    }
}
