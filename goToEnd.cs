using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToEnd : MonoBehaviour
{
    public Animator transitionAnimation;
    public string sceneName;

    private void OnTriggerEnter(Collider other)
    {
        //////if (other.CompareTag("Player"))
        //////{
        //////    SceneManager.LoadScene("Ship");
        //////}
        ///
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LoadScene());
        }
    }

    private IEnumerator LoadScene()
    {
        transitionAnimation.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

}