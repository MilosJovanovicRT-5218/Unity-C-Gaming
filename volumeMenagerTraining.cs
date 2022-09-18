using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeMenagerTraining : MonoBehaviour
{
    public AudioSource audioSource9;
    public AudioSource audioSource10;

    private float musicVolumee = 1f;
    private void Start()
    {
        audioSource9.Play();
        audioSource10.Play();

    }

    private void Update()
    {
        audioSource9.volume = musicVolumee;
        audioSource10.volume = musicVolumee;

    }

    public void UpdateVolume10(float volume)
    {
        musicVolumee = volume;
    }
}
