using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToMenu : MonoBehaviour
{
  
    public void MEnu()
    {
        SceneManager.LoadScene("UIPocetniEkran");
        ///Time.timeScale = 0;
    }
    private void Update()
    {
       
    }
}
