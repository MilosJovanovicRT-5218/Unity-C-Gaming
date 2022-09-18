using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public class ShootingBullet : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject bullet;
    public float speed = 100f;
    public int totalAmmo = 250;
    private int magAmmo = 0;
    private int magSize = 250;
    public Text ammoText;
    public AudioSource shootingSound;
    public ParticleSystem myzzFlash;





    //Decides how fast the bullet shoots
    //////////////////// public float bulletForce = 20f;
    //public float damage = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmoText();
        shootingSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ///

        // if (Input.GetButtonDown("Fire1"))
        if (Input.GetKeyDown(KeyCode.Mouse0) && magAmmo > 0)
        {
            myzzFlash.Play();
            shootingSound.Play();
            /////// ShootBullet();
            ShootBullet();
            magAmmo--;
            UpdateAmmoText();
        }

        //if (Input.GetKeyDown(KeyCode.E))
        //{
        //    PickUpAmmo(250);
        //}

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }


    private void ShootBullet()
    {
        GameObject cB = Instantiate(bullet, spawnPoint.position, bullet.transform.rotation);
        Rigidbody rig = cB.GetComponent<Rigidbody>();
        // transform.position += transform.forward * speed * Time.deltaTime;
        rig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);//ForceMode.Impulse
        
    }

    public void PickUpAmmo(int amount)
    {
        totalAmmo += amount;
        UpdateAmmoText();
    }
    public void Reload()
    {
        if (magAmmo == magSize)
        {
            return;
        }

        if (totalAmmo >= magSize - magAmmo)
        {
            totalAmmo -= (magSize - magAmmo);
            magAmmo = magSize;
        }
        else
        {
            magAmmo += totalAmmo;
            totalAmmo = 0;
        }
        UpdateAmmoText();
    }

    private void UpdateAmmoText()
    {
        ammoText.text = $"{magAmmo}/{totalAmmo}";
    }
}
