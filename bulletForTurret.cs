using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletForTurret : MonoBehaviour
{
    public float damage = 1.0f;
    public float speedFotBullet;
    public GameObject target;


    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedFotBullet);
    }


}
