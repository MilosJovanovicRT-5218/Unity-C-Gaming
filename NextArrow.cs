using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextArrow : MonoBehaviour
{
    public GameObject arrowOne;
    public GameObject arrowTwo;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            arrowOne.SetActive(false);
            arrowTwo.SetActive(true);
        }
    }
}
