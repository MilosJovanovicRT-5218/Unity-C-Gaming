using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Krajjj : MonoBehaviour
{
    // Start is called before the first frame update

    //////private void OnTriggerEnter(Collider other)
    //////{
    //////    if (other.CompareTag("Player"))
    //////    {
    //////        SceneManager.LoadScene("Krajjj");

    //////        Cursor.lockState = CursorLockMode.None;
    //////        Cursor.visible = true;
    //////    }
    //////}
    ///
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
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private IEnumerator LoadScene()
    {
        transitionAnimation.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
