using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KutijaHealth : MonoBehaviour
{
    public GameObject arrowOne;
    public GameObject arrowTwo;
    public int health = 18;

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        ///transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    void OnDamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
            arrowOne.SetActive(false);
            arrowTwo.SetActive(true);
        }
    }
}
