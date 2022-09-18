using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetaKrece : MonoBehaviour
{

    public GameObject planeta;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            planeta.SetActive(true);
        }
    }

}
