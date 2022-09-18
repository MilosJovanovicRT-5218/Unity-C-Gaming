using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossHealth : MonoBehaviour
{
    public int health =50;
    //private float DespawnTime = 10f;
    Animator animator;
    [SerializeField] private GameObject ugasiBossHealth;
    public AudioSource shark;
    public AudioSource boss;

    public GameObject Ship;
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
        ////////if (health == 15)
        ////////{

        ////////    animator.SetBool("ranjen", true);
        ////////    //Destroy(gameObject);
        ////////    //ne mrda kad umre

        ////////}

        if (health <= 20)
        {
            animator.SetBool("ranjen", true);
            //Destroy(gameObject);
            //ne mrda kad umre

        }
        if (health <= 18)
        {
            animator.SetBool("ranjen", true);
            //Destroy(gameObject);
            //ne mrda kad umre

        }
        if (health <= 17)
        {

            animator.SetBool("run", true);
            //Destroy(gameObject);
            //ne mrda kad umre

        }
            if (health <= 0)
            {
                shark.Stop();
                boss.Stop();
                Ship.SetActive(true);
                ugasiBossHealth.SetActive(false);
                GetComponent<BossJuri>().enabled = false;

                animator.SetBool("die", true);
                //Destroy(gameObject);
                //ne mrda kad umre
                ///SceneManager.LoadScene("Kraj");
                ///
            }
        }
}
