using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaHealth : MonoBehaviour
{
    public int health = 1;

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
