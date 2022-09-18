using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public void setFullscreen(bool fullscreen)
    {
        Screen.fullScreen = fullscreen;
        print("FullScreen"+ fullscreen);
    }
}
