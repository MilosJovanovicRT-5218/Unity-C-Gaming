using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretHealth : MonoBehaviour
{

    public int health = 3;
    Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
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
