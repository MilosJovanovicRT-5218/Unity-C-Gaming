using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    ///public GameObject firstPersonCamera;
    public GameObject thirdPersonCamera;
    public GameObject backCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //////if (Input.GetKey(KeyCode.B))
        //////{
        //////    thirdPersonCamera.SetActive(true);
        //////    firstPersonCamera.SetActive(false);
        //////    backCamera.SetActive(false);
        //////}

        //////if (Input.GetKey(KeyCode.V))
        //////{
        //////    thirdPersonCamera.SetActive(false);
        //////    firstPersonCamera.SetActive(true);
        //////    backCamera.SetActive(false);
        //////}

        if (Input.GetKey(KeyCode.C))
        {
            thirdPersonCamera.SetActive(false);
            //firstPersonCamera.SetActive(false);
            backCamera.SetActive(true);
        }
        else
        {
            thirdPersonCamera.SetActive(true);
            //firstPersonCamera.SetActive(false);
            backCamera.SetActive(false);
        }
    }
}
