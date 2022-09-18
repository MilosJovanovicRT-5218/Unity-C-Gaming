using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TurretShoot : MonoBehaviour
{

    //////public GameObject Enemy;
    //////public GameObject Bullet;
    //////public float bulletForce = 200f;

    //////private Vector3 direction;

    //////void Start()
    //////{
    //////    ShootFunctionRepeat();
    //////}

    //////// Update is called once per frame
    //////void Update()
    //////{
    //////    direction = (Enemy.transform.position - this.transform.position).normalized;
    //////}

    //////void ShootFunctionRepeat()
    //////{
    //////    InvokeRepeating("ShootFunction", 1.0f, 3.0f);
    //////}

    //////void ShootFunction()
    //////{
    //////    GameObject temp = Instantiate(Bullet, this.transform.position, Quaternion.identity);
    //////    temp.GetComponent<Rigidbody>().AddForce(direction.normalized * bulletForce);
    //////}
    ///
    /////////////////////////////////////////////////

    //private GameObject target;
    //////    public bool targetLocked;
    //////    public GameObject target;
    //////    public GameObject Bullet;
    //////    public float bulletForce = 100f;

    //////    private Vector3 direction;
    //////    public GameObject turretTopPart;



    //////    private void Start()
    //////    {
    //////        ShootFunctionRepeat();
    //////    }
    //////    private void Update()
    //////    {

    //////        if (targetLocked)
    //////        {
    //////            turretTopPart.transform.LookAt(target.transform);
    //////            turretTopPart.transform.Rotate(-103, 0, 0);
    //////        }

    //////    }

    //////    private void OnTriggerEnter(Collider other)
    //////    {
    //////        if (other.tag == "Player")
    //////        {
    //////            target = other.gameObject;
    //////            targetLocked = true;
    //////        }
    //////    }


    //////    void ShootFunctionRepeat()
    //////    {
    //////        InvokeRepeating("ShootFunction", 0.0f, 1.0f);
    //////    }

    //////    void ShootFunction(GameObject Bullet)
    //////    {
    //////        GameObject temp = Instantiate(Bullet, this.transform.position + direction.normalized, Quaternion.identity);
    //////        temp.GetComponent<Rigidbody>().AddForce(direction.normalized * bulletForce);
    //////    }


    //////}
    /////////////////////////////


    public Transform player;
    public float range = 70.0f;
    public float bulletImpulse = 43.0f;
    private bool onRange = false;
    public Transform spawnPoint;
    public Rigidbody projectile;
    public GameObject turretTopPart;

    void Start()
    {
        { if (player == null && GameObject.FindWithTag("Enemy")) player = GameObject.FindWithTag("Enemy").transform; }
        float rand = UnityEngine.Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 2, rand);
    }

    void Shoot()
    {

        if (onRange)
        {

            Rigidbody bullet = (Rigidbody)Instantiate(projectile, spawnPoint.position, projectile.transform.rotation);
            bullet.AddForce(spawnPoint.forward * bulletImpulse, ForceMode.Impulse);

            Destroy(bullet.gameObject, 2);
        }


    }

    void Update()
    {
        if (player == null) return;
        //turretTopPart.transform.Rotate(-103, 0, 0);
        onRange = Vector3.Distance(transform.position, player.position) < range;

        if (onRange)
            ///  transform.LookAt(player);
            turretTopPart.transform.LookAt(player.transform);
        turretTopPart.transform.Rotate(-93, 0, 0);

    }


}

//////public Transform player;
//////public float range = 50.0f;
//////public float bulletImpulse = 20.0f;
//////private bool onRange = false;

//////public Rigidbody projectile;

//////void Start()
//////{
//////    float rand = UnityEngine.Random.Range(1.0f, 2.0f);
//////    InvokeRepeating("Shoot", 2, rand);
//////}

//////void Shoot()
//////{

//////    if (onRange)
//////    {

//////        Rigidbody bullet = (Rigidbody)Instantiate(projectile, transform.position + transform.forward, transform.rotation);
//////        bullet.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);

//////        Destroy(bullet.gameObject, 2);
//////    }


//////}

//////void Update()
//////{
//////    //turretTopPart.transform.Rotate(-103, 0, 0);
//////    onRange = Vector3.Distance(transform.position, player.position) < range;

//////    if (onRange)
//////        transform.LookAt(player);
//////}


//////}