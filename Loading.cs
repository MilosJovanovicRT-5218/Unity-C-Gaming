using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Loading : MonoBehaviour
{

    ////////public GameObject LoadingScreen;
    ////////public Image LoadingBarFill;

    ////////public void LoadScene(int sceneId)
    ////////{
    ////////    StartCoroutine(LoadingSceneAsync(sceneId));
    ////////}

    ////////IEnumerator LoadingSceneAsync(int sceneId)
    ////////{
    ////////    AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

    ////////    LoadingScreen.SetActive(true);

    ////////    while (!operation.isDone)
    ////////    {
    ////////        float pogresValue = Mathf.Clamp01(operation.progress / 0.9f);
    ////////        LoadingBarFill.fillAmount = pogresValue;

    ////////        yield return null;
    ////////    }
    ////////}
    ///
    public GameObject LoadingScreen;
    public Slider slider;

    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadingSceneAsync(levelIndex));
    }

    IEnumerator LoadingSceneAsync(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            slider.value = operation.progress;
            yield return null;
        }
    }

}