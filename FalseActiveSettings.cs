using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseActiveSettings : MonoBehaviour
{
    public GameObject SettingsFalse;

    public void CloseSettings()
    {
        SettingsFalse.SetActive(false);
    }
}
