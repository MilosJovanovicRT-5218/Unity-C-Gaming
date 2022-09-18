using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterStats : MonoBehaviour
{
    public AudioSource audioData;
    
    //public float currHealth;
    //public float maxHealth;

    //public float currStamina;
    //public float maxStamina;

    //public bool dead = true;
    //Animator animator;
    //// Start is called before the first frame update

    //public virtual void CheckHealth()
    //{
    //    if (currHealth >= maxHealth)
    //    {
    //        currHealth = maxHealth;
    //    }
    //    if (currHealth <= 0)
    //    {
    //        currHealth = 0;
    //        dead = true;
    //        Death();
    //    }
    //}
    //private void Death()
    //{
    //    animator.SetBool("dead", true);
    //}
    //public virtual void CheckStamina()
    //{
    //    if (currStamina >= maxStamina)
    //    {
    //        currStamina = maxStamina;
    //    }
    //    if (currStamina <= 0)
    //    {
    //        currStamina = 0;
    //    }
    //}


    //public void TakeDemage(float demage)
    //{
    //    currHealth -= demage;
    //}


    //void Start()
    //{
    //    animator = GetComponent<Animator>();
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public int health = 5;
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
            audioData.Play();
            //Destroy(gameObject);
            GetComponent<Enemy>().enabled = false;//ne mrda kad umre
            animator.SetBool("die", true);
        }
    }
    

}

