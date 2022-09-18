using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPick : MonoBehaviour
{

    int ammo_amount = 50;
    //public GameObject ammoSound;

    private void Start()
    {
       // ammoSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            other.GetComponentInChildren<ShootingBullet>().PickUpAmmo(ammo_amount);
            Destroy(gameObject);
           // ammoSound.SetActive(true);
        }
        else
        {
            //ammoSound.SetActive(false);
        }
        //if (other.CompareTag("Sword"))
        //{

        //    other.GetComponentInChildren<ShootingBullet>().PickUpAmmo(ammo_amount);
        //    Destroy(gameObject);
        //}
    }

    //void ammo()
    //{
    //    ammoSound.SetActive(true);
    //}

    //void ammoStop()
    //{
    //    ammoSound.SetActive(false);
    //}

}
