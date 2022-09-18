using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeMenagerSample : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;

    private float musicVolume = 1f;
    private void Start()
    {
        audioSource.Play();
        audioSource2.Play();
        audioSource3.Play();

    }

    private void Update()
    {
        audioSource.volume = musicVolume;
        audioSource2.volume = musicVolume;
        audioSource3.volume = musicVolume;

    }

    public void UpdateVolume3(float volume)
    {
        musicVolume = volume;
    }
}
