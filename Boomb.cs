using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boomb : MonoBehaviour
{
    public GameObject explosionEffect;
    public float delay = 3f;
    public float explosionForce = 10f;
    public float radius = 20f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Explode()
    {
        //Cheaking nearby colliders
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        //Applying them a force
        foreach(Collider near in colliders)
            {
            Rigidbody rig = near.GetComponent<Rigidbody>();

            if (rig != null)
                rig.AddExplosionForce(explosionForce, transform.position, radius, 1f, ForceMode.Impulse);
            }
        //Exolosion Effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
