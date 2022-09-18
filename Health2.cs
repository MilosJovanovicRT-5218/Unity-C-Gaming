using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health2 : MonoBehaviour
{
    //public Image healtBar;
    //public float health;
    //public float startHealth;

    //Start is called before the first frame update
    //void Start()
    //{

    //}

    //Update is called once per frame
    //void Update()
    //{

    //}

    ////////public void OnTakeDemage(int demage)
    ////////{
    ////////    health = health - demage;
    ////////    healtBar.fillAmount = health / startHealth;
    ////////}
    [SerializeField] private GameObject restartUI;
    [SerializeField] private GameObject ESC;
    [SerializeField] private GameObject Dialog;

    public int Health = 100;
    public int AddHealth;
    // public bool gameOver;
    private Animator animator;
    float timeColliding;
    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Health <= 0)
            {
            GetComponent<CameraRotation>().enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            restartUI.SetActive(true);
            animator.SetBool("die", true);
            GetComponent<Movement>().enabled = false;//ne mrda kad umre <naziv klase koja sluzi za movement,samo je od cekuje eneble>
            // restartUI.SetActive(true);
            //  animator.SetBool("die", true);
            //  gameOver = true;
        }
        //////if (Input.GetKey(KeyCode.Escape))
        //////{
        //////    ESC.SetActive(true);
        //////    Cursor.lockState = CursorLockMode.None;
        //////    Cursor.visible = true;
        //////}
        //////else 
        //////{
        //////    ESC.SetActive(false);
        //////    Cursor.lockState = CursorLockMode.None;
        //////    Cursor.visible = true;
        //////}



    }

    

    public void RestartButton()
    {
        SceneManager.LoadScene("TrainingScene");
    }


    //////////////////////////void OnCollisionEnter(Collision collision)
    //////////////////////////{

    //////////////////////////    if (collision.gameObject.tag == "EnemyPlsnt")
    //////////////////////////    {

    //////////////////////////        Debug.Log("Enemy started colliding with player.");


    //////////////////////////        this.Health -= 10;

    //////////////////////////    }

    //////////////////////////}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyPlant"))
        {
            Debug.Log("Enemy started colliding with player.");

            this.Health -= 8;
        }

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy started colliding with player.");


            this.Health -= 5;
           
        }

        if (other.CompareTag("Boss"))
        {
            //animator.SetBool("attackBoss", true);
           // Debug.Log("Enemy started colliding with player.");


            this.Health -= 20;
        }

        if (other.CompareTag("Bullet"))
        {
            //animator.SetBool("attackBoss", true);
           Debug.Log("Enemy started colliding with player.");


            this.Health -= 3;

        }

        if (other.CompareTag("Heal"))
        {
            //animator.SetBool("attackBoss", true);
            //Debug.Log("Enemy started colliding with player.");


            this.Health += 10;

        }
        if (other.CompareTag("Spike"))
        {
            //animator.SetBool("attackBoss", true);
            //Debug.Log("Enemy started colliding with player.");


            this.Health -= 5;

        }
        if (other.CompareTag("Lava"))
        {
            //animator.SetBool("attackBoss", true);
            //Debug.Log("Enemy started colliding with player.");


            this.Health -= 100;

        }
        if (other.CompareTag("Axe"))
        {
            //animator.SetBool("attackBoss", true);
           // Debug.Log("Enemy started colliding with player.");


            this.Health -= 20;

        }
        if (other.CompareTag("Dialog"))
        {
            Dialog.SetActive(true);
            //Cursor.visible = true;

        }
        if (other.CompareTag("KrajDialog"))
        {
            Dialog.SetActive(false);
            //Cursor.visible = false;
        }

    }
}

