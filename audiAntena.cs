using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiAntena : MonoBehaviour
{
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
