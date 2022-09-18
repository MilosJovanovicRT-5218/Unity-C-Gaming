using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Bullet : MonoBehaviour
{


    //public float Demage = -0.5f;
    //[Header("Unity Setup")]
    //public ParticleSystem deathParticle;
    //Start is called before the first frame update
    //////////void Start()
    //////////{

    //////////}

    // Update is called once per frame
    //private void OnClossisionsEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //}

    //private void OnClossisionsEnter(Collision collision)
    //{
    //    if (collision.collider.CompareTag("Enemy")) ;
    //    {
    //        Destroy();
    //    }
    //}

    //public void Destroy()
    //{
    //    Destroy(gameObject);
    //}

    //////////////////////////    public void OnTriggerEnter(Collider other)
    //////////////////////////    {
    //////////////////////////        if (other.CompareTag("Enemy"))
    //////////////////////////        {
    //////////////////////////            //Instantiate(deathParticle, transform.position, Quaternion.identity);
    //////////////////////////            //Destroy the thing tagged enemy, not youself

    //////////////////////////            //other.GetComponent<ScoringSystem>().TakeDemage(demage);

    //////////////////////////            ScoringSystem.theScore += 50;

    //////////////////////////            Destroy(other.gameObject);

    //////////////////////////            // Could still destroy the bullet itself as well
    //////////////////////////            Destroy(gameObject);
    //////////////////////////        }

    //////////////////////////        if (other.CompareTag("EnemyPlant"))
    //////////////////////////        {

    //////////////////////////            //Instantiate(deathParticle, transform.position, Quaternion.identity);
    //////////////////////////            //Destroy the thing tagged enemy, not youself
    //////////////////////////            ScoringSystem.theScore += 50;

    //////////////////////////            Destroy(other.gameObject);

    //////////////////////////            // Could still destroy the bullet itself as well
    //////////////////////////            Destroy(gameObject);
    //////////////////////////        }
    //////////////////////////    }
    //////////////////////////}

    //public float speed = 10.0F;
    ////////public float damage = 10.0f;

    //Use this for initialization


    //Update is called once per frame

    //////////void Update()
    //////////{
    //////////    transform.Translate(0, 0, speed);
    //////////}
    //////////void OnTriggerEnter(Collider Enemy)
    //////////{
    //////////    if (Enemy.gameObject.CompareTag("Enemy"))
    //////////    {
    //////////        Enemy.gameObject.SendMessage("OnDamage", damage);
    //////////    }

    //////////}
    ///

    public float damage = 1.0f;
    // Use this for initialization

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
          //  ScoringSystem.theScore += 50;
            other.gameObject.SendMessage("OnDamage", damage);
        }

        if (other.CompareTag("EnemyPlant"))
        {
          //  ScoringSystem.theScore += 50;
            other.gameObject.SendMessage("OnDamage", damage);
        }
        if (other.CompareTag("Kutija"))
        {
            //  ScoringSystem.theScore += 50;
            other.gameObject.SendMessage("OnDamage", damage);
        }
        if (other.CompareTag("Boss"))
        {
            //  ScoringSystem.theScore += 50;
            other.gameObject.SendMessage("OnDamage", damage);
        }
        if (other.CompareTag("Meta"))
        {
            //  ScoringSystem.theScore += 50;
            other.gameObject.SendMessage("OnDamage", damage);
        }
        if (other.CompareTag("Player"))
        {
            //  ScoringSystem.theScore += 50;
           // other.gameObject.SendMessage("OnDamage", damage);
        }
        if (other.CompareTag("Turret"))
        {
            //  ScoringSystem.theScore += 50;
            other.gameObject.SendMessage("OnDamage", damage);
        }
    }

    // Virtual means you can override this method in child classes

}

//////https://stackoverflow.com/questions/69048364/why-is-my-player-not-taking-damage-from-an-enemy