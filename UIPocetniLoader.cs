using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPocetniLoader : MonoBehaviour
{
    private void OnEnable()
    { 
            SceneManager.LoadScene("UIPocetniEkran", LoadSceneMode.Single);
    }
}
