using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalManager2 : MonoBehaviour
{
    public Transform Apos;
    public Transform Bpos;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("PortalA"))
        {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = Bpos.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, Bpos.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;
        }

        if (collider.CompareTag("PortalB"))
        {
            CharacterController cc = GetComponent<CharacterController>();

            cc.enabled = false;
            transform.position = Apos.transform.position;
            transform.rotation = new Quaternion(transform.rotation.x, Apos.rotation.y, transform.rotation.z, transform.rotation.w);

            cc.enabled = true;
        }
    }

}
