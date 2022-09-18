using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FremaleHurtSound : MonoBehaviour
{

    public GameObject hurt1;

    // Start is called before the first frame update
    void Start()
    {
        hurt1.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("EnemyPlant") || other.CompareTag("Axe") || other.CompareTag("Boss") || other.CompareTag("Spike") || other.CompareTag("Bullet"))
        {
            hurt1.SetActive(true);
        }

        else
        {
            hurt1.SetActive(false);
        }
        //if (other.CompareTag("Axe"))
        //{
        //    hurt1.SetActive(true);
        //}

        //else
        //{
        //    hurt1.SetActive(false);
        //}
        //if (other.CompareTag("Boss"))
        //{
        //    hurt1.SetActive(true);
        //}

        //else
        //{
        //    hurt1.SetActive(false);
        //}
        //if (other.CompareTag("EnemyPlant"))
        //{
        //    hurt1.SetActive(true);
        //}

        //else
        //{
        //    hurt1.SetActive(false);
        //}
    }

    void hurt()
    {
        hurt1.SetActive(true);
    }

    void stophurt()
    {
        hurt1.SetActive(false);
    }
}
