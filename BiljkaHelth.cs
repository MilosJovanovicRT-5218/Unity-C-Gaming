using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiljkaHelth : MonoBehaviour
{
    public int health = 3;

    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }
}