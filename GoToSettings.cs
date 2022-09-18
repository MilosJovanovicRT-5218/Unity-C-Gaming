using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSettings : MonoBehaviour
{
    public GameObject Settings;

    public void OpenSettings()
    {
        Settings.SetActive(true);
    }
}
