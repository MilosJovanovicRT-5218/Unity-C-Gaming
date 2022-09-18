using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal2 : MonoBehaviour
{
    public Transform teleportTarget2;
    public GameObject thePlayer2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        thePlayer2.transform.position = teleportTarget2.transform.position;
    }
}
