using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Animator transition;
    public float transitionTime = 1f;

    

   public  void LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        //  yield return new WaitForSeconds(transitionTime);
        StartCoroutine(LoadAsync(levelIndex));
;     
        
    }
    IEnumerator LoadAsync(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
      //  loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }
}
