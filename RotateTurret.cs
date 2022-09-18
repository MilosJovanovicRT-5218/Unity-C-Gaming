using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTurret : MonoBehaviour
{
    public GameObject turretTopPart;
    private GameObject target;
    public bool targetLocked;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
            
            turretTopPart.transform.Rotate(-103, 0, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
            targetLocked = true;
        }
    }

}