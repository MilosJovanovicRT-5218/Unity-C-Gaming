using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quality : MonoBehaviour
{
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }


    List<int> widths = new List<int>() { 1336, 1920, 1920 };
    List<int> heights = new List<int>() { 768, 768, 1080 };

    public void SetResolution(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);
    }
}
