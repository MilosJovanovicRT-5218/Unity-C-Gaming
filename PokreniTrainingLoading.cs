using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PokreniTrainingLoading : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("TrainingScene", LoadSceneMode.Single);
    }
}
