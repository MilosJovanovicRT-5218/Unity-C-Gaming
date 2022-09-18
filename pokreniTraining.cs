using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pokreniTraining : MonoBehaviour
{
    ////public Animator transitionAnimation;
    ////public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
         
}

    // Update is called once per frame
    void Update()
    {
        ///Time.timeScale = 1;
        
            //////StartCoroutine(LoadScene());
        
    }

    public void PokreniTraining()
    {
        SceneManager.LoadScene("Loading"); 

    }

    ////////private IEnumerator LoadScene()
    ////////{
    ////////    transitionAnimation.SetTrigger("end");
    ////////    yield return new WaitForSeconds(1.5f);
    ////////    SceneManager.LoadScene(sceneName);
    ////////}

}
