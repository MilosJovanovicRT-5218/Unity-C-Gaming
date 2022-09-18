using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class BossJuri : MonoBehaviour
{
    [SerializeField] float demage;
    [SerializeField] float stoppingDistance;

    NavMeshAgent agent;

    GameObject target;

    Animator animator;

    public void GameOver()
    {

    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float dist = Vector3.Distance(transform.position, target.transform.position);
        if (dist < stoppingDistance)
        {
            StopEnemy();
            //   target.GetComponent<CharacterStats>().TakeDamage(demage);
        }
        else
        {
            GoToTarget();
        }
    }
    private void GoToTarget()
    {
        agent.isStopped = false;
        agent.SetDestination(target.transform.position);
    }
    private void StopEnemy()
    {
        agent.isStopped = true;
    }
    ///
    /// 
    /// 
    /// 
    /// 
    /// Gore
    //////////////////private void OnTriggerEnter(Collider other)
    //////////////////{
    //////////////////    if (other.CompareTag("Player"))
    //////////////////    {
    //////////////////        //Instantiate(deathParticle, transform.position, Quaternion.identity);
    //////////////////        //Destroy the thing tagged enemy, not youself

    //////////////////        ///Application.Quit();


    //////////////////        Destroy(other.gameObject);

    //////////////////        // animator.SetBool("die", true);

    //////////////////        // Could still destroy the bullet itself as well
    //////////////////        Destroy(gameObject);

    //////////////////    }
    //////////////////}



    //all variables

}
