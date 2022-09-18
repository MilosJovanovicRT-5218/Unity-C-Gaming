using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KreceIgra : MonoBehaviour
{

    public Animator transitionAnimation;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //////Destroy(gameObject);
            //////SceneManager.LoadScene("SampleScene");
            ///
            StartCoroutine(LoadScene());
            SceneManager.LoadScene("SampleScene");
        }
    }

    private IEnumerator LoadScene()
    {
        transitionAnimation.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

}
