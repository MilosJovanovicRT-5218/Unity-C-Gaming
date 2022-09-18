using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacijaSmrtienemy : MonoBehaviour
{

    //ne radi
    [Header("Unity Setup")]
    public ParticleSystem deathParticle;
    // Start is called before the first frame update
    void onColisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy();
        }
    }

    // Update is called once per frame
    public void Destroy()
    {
        Instantiate(deathParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
