using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundForButton : MonoBehaviour
{
    public AudioSource mySound;
    public AudioClip hoverSound;
    ///public AudioClip clickSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HoverSound()
    {
        mySound.PlayOneShot(hoverSound);
    }

    //////////public void ClikcSound()
    //////////{
    //////////    mySound.PlayOneShot(clickSound);
    //////////}
}
