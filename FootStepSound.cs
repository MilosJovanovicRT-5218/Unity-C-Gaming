using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepSound : MonoBehaviour
{
    //////    public AudioSource audioSource2;
    //////    public AudioClip FootStep;
    //////    private bool IsMoving;

    //////    void Start()
    //////    {
    //////        audioSource2 = gameObject.GetComponent<AudioSource>();
    //////    }

    //////    void Update()
    //////    {
    //////        if (Input.GetAxis("Vertical") < 0) IsMoving = true; // better use != 0 here for both directions
    //////        else IsMoving = false;

    //////        if (IsMoving && !audioSource2.isPlaying) audioSource2.Play(); // if player is moving and audiosource is not playing play it
    //////        if (!IsMoving) audioSource2.Stop(); // if player is not moving and audiosource is playing stop it
    //////    }
    //////}
    ///
    public GameObject footstep;

    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("s"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("a"))
        {
            footsteps();
        }

        if (Input.GetKeyDown("d"))
        {
            footsteps();
        }
        if (Input.GetKeyDown("space"))
        {
            footsteps();
        }

        if (Input.GetKeyUp("w"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("s"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("a"))
        {
            StopFootsteps();
        }

        if (Input.GetKeyUp("d"))
        {
            StopFootsteps();
        }
        if (Input.GetKeyUp("space"))
        {
            StopFootsteps();
        }

    }

    void footsteps()
    {
        footstep.SetActive(true);
    }

    void StopFootsteps()
    {
        footstep.SetActive(false);
    }
}
