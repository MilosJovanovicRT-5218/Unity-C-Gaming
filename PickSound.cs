using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSound : MonoBehaviour
{
    public GameObject pickSound;

    // Start is called before the first frame update
    void Start()
    {
        pickSound.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin") || other.CompareTag("Heal") || other.CompareTag("Pokupi"))
        {
            pickSound.SetActive(true);
        }

        else
        {
            pickSound.SetActive(false);
        }
    }

    void pick()
    {
        pickSound.SetActive(true);
    }

    void pickstop()
    {
        pickSound.SetActive(false);
    }
}
