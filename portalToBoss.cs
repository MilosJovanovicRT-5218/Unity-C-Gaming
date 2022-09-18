
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalToBoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //////void OnTriggerEnter(Collider other)
    //////{
    //////    if (other.CompareTag("Player"))
    //////    {
    //////        Destroy(gameObject);
    //////        SceneManager.LoadScene("BossScene");
    //////    }
    //////}

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