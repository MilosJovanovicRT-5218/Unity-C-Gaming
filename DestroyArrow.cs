using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArrow : MonoBehaviour
{

   public GameObject Player;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            Destroy(gameObject);
            Destroy(GameObject.FindWithTag("Arrow"));
           /// gameObject.SetActive(false);
        }  
    }
}
