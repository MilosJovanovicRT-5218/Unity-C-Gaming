using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class CameraRotation : MonoBehaviourPunCallbacks
{
    //////////////////////public Vector2 turn;
    //////////////////////public float sensitivity = .8f;
    //////////////////////public Vector3 deltaMove;
    //////////////////////public float speed = 1;




    //////////////////////public float horizontalSpeed = 2.0F;
    //////////////////////public float verticalSpeed = 2.0F;
    //////////////////////void Start()
    //////////////////////{
    //////////////////////  Cursor.lockState = CursorLockMode.Locked;
    //////////////////////}
    //////////////////////void Update()
    //////////////////////{
    //////////////////////    turn.x += Input.GetAxis("Mouse X") * sensitivity;
    //////////////////////    turn.y += Input.GetAxis("Mouse Y") * sensitivity;
    //////////////////////    transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);


    //////////////////////}
    ///
    ///public GameObject aim;
    ///





    //////////////////////////////////////////////////////////////////////////////public Camera cam;//Main camera for rotate in y-axis
    //////////////////////////////////////////////////////////////////////////////void Update()               //Updated every frame;
    //////////////////////////////////////////////////////////////////////////////{
    //////////////////////////////////////////////////////////////////////////////    this.LookRotation(transform, cam.transform);    //Call LookRotation() to change the x-rotation of the gameobject and the y-rotation of camera
    //////////////////////////////////////////////////////////////////////////////}
    //////////////////////////////////////////////////////////////////////////////public void LookRotation(Transform character, Transform camera)     //Change the x-rotation of the gameobject and the y-rotation of camera
    //////////////////////////////////////////////////////////////////////////////{
    //////////////////////////////////////////////////////////////////////////////    float yRot = Input.GetAxis("Mouse X") * 2f;     //get x and y of mouse in screen
    //////////////////////////////////////////////////////////////////////////////    float xRot = Input.GetAxis("Mouse Y") * 2f;
    //////////////////////////////////////////////////////////////////////////////    character.localRotation *= Quaternion.Euler(0f, yRot, 0f);      //To change character's rotation around y-axis
    //////////////////////////////////////////////////////////////////////////////    camera.localRotation *= Quaternion.Euler(-xRot, 0f, 0f);        //To change camera's rotation around x-axis
    //////////////////////////////////////////////////////////////////////////////    camera.localRotation = ClampRotationAroundXAxis(camera.localRotation);  //Clamp camera's rotation
    //////////////////////////////////////////////////////////////////////////////}                                                                   //The key point is use localRotation,not rotation or Quaternion.Rotate.
    //////////////////////////////////////////////////////////////////////////////Quaternion ClampRotationAroundXAxis(Quaternion q)       //The method of clamp rotation,I can't understand it;use it carefully.
    //////////////////////////////////////////////////////////////////////////////{
    //////////////////////////////////////////////////////////////////////////////    q.x /= q.w;
    //////////////////////////////////////////////////////////////////////////////    q.y /= q.w;
    //////////////////////////////////////////////////////////////////////////////    q.z /= q.w;
    //////////////////////////////////////////////////////////////////////////////    q.w = 1.0f;
    //////////////////////////////////////////////////////////////////////////////    float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);
    //////////////////////////////////////////////////////////////////////////////    angleX = Mathf.Clamp(angleX, 0f, 90f);
    //////////////////////////////////////////////////////////////////////////////    q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);
    //////////////////////////////////////////////////////////////////////////////    return q;
    //////////////////////////////////////////////////////////////////////////////}

    //////////////////////////////////////////////////////////////////////////////private void Start()
    //////////////////////////////////////////////////////////////////////////////{
    //////////////////////////////////////////////////////////////////////////////    Cursor.lockState = CursorLockMode.Locked;
    //////////////////////////////////////////////////////////////////////////////}












    public Camera cam;          //Main camera for rotate in y-axis
    void Update()               //Updated every frame;
    {

       // this.LookRotation(transform, cam.transform);    //Call LookRotation() to change the x-rotation of the gameobject and the y-rotation of camera

        
            this.LookRotation(transform, cam.transform);
        

    }
    public void LookRotation(Transform character, Transform camera)     //Change the x-rotation of the gameobject and the y-rotation of camera
    {
        float yRot = Input.GetAxis("Mouse X") * 2f;     //get x and y of mouse in screen
        float xRot = Input.GetAxis("Mouse Y") * 2f;
        character.localRotation *= Quaternion.Euler(0f, yRot, 0f);      //To change character's rotation around y-axis
        camera.localRotation *= Quaternion.Euler(-xRot, 0f, 0f);        //To change camera's rotation around x-axis
        camera.localRotation = ClampRotationAroundXAxis(camera.localRotation);  //Clamp camera's rotation
    }                                                                   //The key point is use localRotation,not rotation or Quaternion.Rotate.
    Quaternion ClampRotationAroundXAxis(Quaternion q)       //The method of clamp rotation,I can't understand it;use it carefully.
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;
        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);
        angleX = Mathf.Clamp(angleX, -40f, 12f);
        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);
        return q;
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

  

}











////////////internal static Vector3 WorldToScreenPoint(Vector3 position)
////////////{
////////////    throw new NotImplementedException();
////////////}

////////////internal static Vector3 ScreenToWordPoint(Vector3 curScreenPoint)
////////////{
////////////    throw new NotImplementedException();
////////////}

