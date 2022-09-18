using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeMenager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;
    private float musicVolume = 1f;
    private void Start()
    {
        audioSource.Play();
        audioSource2.Play();
        audioSource3.Play();
        audioSource4.Play();
    }

    private void Update()
    {
        audioSource.volume = musicVolume;
        audioSource2.volume = musicVolume;
        audioSource3.volume = musicVolume;
        audioSource4.volume = musicVolume;
    }

    public void UpdateVolume(float volume)
    {
        musicVolume = volume;
    }
}