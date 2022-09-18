using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class asd : MonoBehaviour
{
    //////private Vector3 screenPoint;

    //////void Start()
    //////{
    //////    screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    //////}

    //////void Update()
    //////{
    //////    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z); ///screenPoint.z
    //////     Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
    //////    transform.position = curPosition;
    //////}
    /// <summary>
    /// 
    /// 
    /// </summary>
    [SerializeField] private Camera mainCamera;


    private void Start()
    {
        Debug.Log(mainCamera.ScreenToWorldPoint(Input.mousePosition));
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }


    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }
    }
}