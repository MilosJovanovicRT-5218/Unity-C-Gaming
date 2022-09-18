using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Animation2 : MonoBehaviourPunCallbacks
{
    //public Camera GlavnaCamera;
    //public float defaultFov = 80;
    /////public GameObject Gun;
    /////public AudioSource walk;
    ////public float movementSpeed = 10;
    ////public float turningSpeed = 60;
    ////public float verticalTurnSpeed = 50;
    //public float strafeSpeed = 20;
    ////bool strafe = true;

    //Animator animator;

    //public GameObject gun;
    //public GameObject pistol;

    //public GameObject gunImg;
    //public GameObject swordImg;

    //public GameObject ammoGunText;
    //public GameObject ammoPistolText;

    ////public GameObject gunText;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    animator = GetComponent<Animator>();
    //    pistol.SetActive(false);
    //    swordImg.SetActive(false);
    //    ammoPistolText.SetActive(false);

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (photonView.IsMine)
    //   {
    //        AnimationOnlineee();
    //   }
    //}
    //public void AnimationOnlineee()
    //{
    //    if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
    //    {
    //        gun.SetActive(true);
    //        ammoGunText.SetActive(true);
    //        ammoPistolText.SetActive(false);
    //        pistol.SetActive(false);
    //        gunImg.SetActive(true);
    //        swordImg.SetActive(false);
    //    }
    //    if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
    //    {
    //        pistol.SetActive(true);
    //        gun.SetActive(false);
    //        ammoGunText.SetActive(false);
    //        ammoPistolText.SetActive(true);
    //        gunImg.SetActive(false);
    //        swordImg.SetActive(true);
    //    }


    //    if (Input.GetKey("1"))
    //    {
    //        gun.SetActive(true);
    //        ammoGunText.SetActive(true);
    //        ammoPistolText.SetActive(false);
    //        pistol.SetActive(false);
    //        gunImg.SetActive(true);
    //        swordImg.SetActive(false);
    //    }

    //    if (Input.GetKey("2"))
    //    {

    //        pistol.SetActive(true);
    //        gun.SetActive(false);
    //        ammoGunText.SetActive(false);
    //        ammoPistolText.SetActive(true);
    //        gunImg.SetActive(false);
    //        swordImg.SetActive(true);
    //    }


    //    //if (Input.GetKey("w"))
    //    //{
    //    //    animator.SetBool("isWalk", true);
    //    //    ///AssaultRifle.gameObject.SetActive(false);

    //    //}
    //    //else
    //    //{
    //    //    animator.SetBool("isWalk", false);
    //    //}

    //    if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
    //    {
    //        animator.SetBool("isWalk", true);

    //    }
    //    else
    //    {
    //        animator.SetBool("isWalk", false);
    //    }

    //    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
    //    {
    //        animator.SetBool("walkLeft", true);

    //    }
    //    else
    //    {
    //        animator.SetBool("walkLeft", false);
    //    }

    //    if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
    //    {
    //        animator.SetBool("backWalk", true);

    //    }
    //    else
    //    {
    //        animator.SetBool("backWalk", false);
    //    }

    //    if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
    //    {
    //        animator.SetBool("walkRight", true);

    //    }
    //    else
    //    {
    //        animator.SetBool("walkRight", false);
    //    }
    //    if (Input.GetKey("space"))
    //    {

    //        animator.SetBool("isJump", true);
    //    }
    //    else
    //    {
    //        animator.SetBool("isJump", false);

    //    }
    //    //if (Input.GetKey("s"))
    //    //{

    //    //    animator.SetBool("backWalk", true);
    //    //}
    //    //else
    //    //{

    //    //    animator.SetBool("backWalk", false);
    //    //}
    //    //if (Input.GetKey("a"))
    //    //{
    //    //    animator.SetBool("walkLeft", true);
    //    //}
    //    //else
    //    //{

    //    //    animator.SetBool("walkLeft", false);
    //    //}
    //    //if (Input.GetKey("d"))
    //    //{

    //    //    animator.SetBool("walkRight", true);
    //    //}
    //    //else
    //    //{
    //    //    animator.SetBool("walkRight", false);
    //    //}
    //    if (Input.GetKey(KeyCode.LeftShift))
    //    {
    //        // AssaultRifle.gameObject.SetActive(false);
    //        animator.SetBool("run", true);
    //    }
    //    else
    //    {
    //        //AssaultRifle.gameObject.SetActive(true);
    //        animator.SetBool("run", false);
    //    }
    //    //////////////if (Input.GetKey(KeyCode.Q))
    //    //////////////{
    //    //////////////    // AssaultRifle.gameObject.SetActive(false);
    //    //////////////    animator.SetBool("bomb", true);
    //    //////////////    ///Gun.SetActive(false);
    //    //////////////}
    //    //////////////else
    //    //////////////{
    //    //////////////    //AssaultRifle.gameObject.SetActive(true);
    //    //////////////    animator.SetBool("bomb", false);
    //    //////////////    ///Gun.SetActive(true);
    //    //////////////}
    //    if (Input.GetKey(KeyCode.LeftControl))
    //    {
    //        animator.SetBool("crouch", true);
    //        ///GetComponent<Movement>().enabled = false;
    //       // GetComponent<Playerrr>().enabled = false;
    //    }
    //    else
    //    {
    //        animator.SetBool("crouch", false);
    //        ///GetComponent<Movement>().enabled = true;
    //        //GetComponent<Playerrr>().enabled = true;
    //    }
    //    //////if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.W))
    //    //////{
    //    //////    animator.SetBool("crouchW", true);
    //    //////}
    //    //////else
    //    //////{
    //    //////    animator.SetBool("crouchW", false);
    //    //////}
    //    if (Input.GetKey(KeyCode.Mouse0))
    //    {
    //        animator.SetBool("fire", true);
    //    }
    //    else
    //    {
    //        animator.SetBool("fire", false);
    //    }
    //    //////if (Input.GetKey(KeyCode.Mouse1))
    //    //////{

    //    //////    //ZoomCamera.SetActive(true);
    //    //////    //GlavnaCamera.SetActive(false);
    //    //////    animator.SetBool("firePripere", true);
    //    //////}
    //    //////else
    //    //////{
    //    //////    //ZoomCamera.SetActive(false);
    //    //////    //GlavnaCamera.SetActive(true);
    //    //////    animator.SetBool("firePripere", false);
    //    //////}
    //    if (Input.GetMouseButton(1))
    //    {
    //        GlavnaCamera.fieldOfView = (defaultFov / 2);
    //    }
    //    else
    //    {
    //        GlavnaCamera.fieldOfView = (defaultFov);
    //    }
    //    if (Input.GetKey(KeyCode.R))
    //    {

    //        animator.SetBool("reload", true);
    //    }
    //    else
    //    {
    //        animator.SetBool("reload", false);
    //    }

    //}



    public Camera GlavnaCamera;
    public float defaultFov = 80;
    ///public GameObject Gun;
    ///public AudioSource walk;
    //public float movementSpeed = 10;
    //public float turningSpeed = 60;
    //public float verticalTurnSpeed = 50;
    public float strafeSpeed = 20;
    //bool strafe = true;

    Animator animator;

    //public GameObject gun;
    //public GameObject pistol;

    //public GameObject gunImg;
    //public GameObject swordImg;

    //public GameObject ammoGunText;
    //public GameObject ammoPistolText;

    //public GameObject gunText;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //pistol.SetActive(false);
        //swordImg.SetActive(false);
        //ammoPistolText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            AnimationOnlineee();
        }
    }
    public void AnimationOnlineee()
    {
        //if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        //{
        //    gun.SetActive(true);
        //    ammoGunText.SetActive(true);
        //    ammoPistolText.SetActive(false);
        //    pistol.SetActive(false);
        //    gunImg.SetActive(true);
        //    swordImg.SetActive(false);
        //}
        //if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        //{
        //    pistol.SetActive(true);
        //    gun.SetActive(false);
        //    ammoGunText.SetActive(false);
        //    ammoPistolText.SetActive(true);
        //    gunImg.SetActive(false);
        //    swordImg.SetActive(true);
        //}


        //if (Input.GetKey("1"))
        //{
        //    gun.SetActive(true);
        //    ammoGunText.SetActive(true);
        //    ammoPistolText.SetActive(false);
        //    pistol.SetActive(false);
        //    gunImg.SetActive(true);
        //    swordImg.SetActive(false);
        //}

        //if (Input.GetKey("2"))
        //{

        //    pistol.SetActive(true);
        //    gun.SetActive(false);
        //    ammoGunText.SetActive(false);
        //    ammoPistolText.SetActive(true);
        //    gunImg.SetActive(false);
        //    swordImg.SetActive(true);
        //}


        //if (Input.GetKey("w"))
        //{
        //    animator.SetBool("isWalk", true);
        //    ///AssaultRifle.gameObject.SetActive(false);

        //}
        //else
        //{
        //    animator.SetBool("isWalk", false);
        //}

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            animator.SetBool("isWalk", true);

        }
        else
        {
            animator.SetBool("isWalk", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("walkLeft", true);

        }
        else
        {
            animator.SetBool("walkLeft", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("backWalk", true);

        }
        else
        {
            animator.SetBool("backWalk", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("walkRight", true);

        }
        else
        {
            animator.SetBool("walkRight", false);
        }
        if (Input.GetKey("space"))
        {

            animator.SetBool("isJump", true);
        }
        else
        {
            animator.SetBool("isJump", false);

        }
        //if (Input.GetKey("s"))
        //{

        //    animator.SetBool("backWalk", true);
        //}
        //else
        //{

        //    animator.SetBool("backWalk", false);
        //}
        //if (Input.GetKey("a"))
        //{
        //    animator.SetBool("walkLeft", true);
        //}
        //else
        //{

        //    animator.SetBool("walkLeft", false);
        //}
        //if (Input.GetKey("d"))
        //{

        //    animator.SetBool("walkRight", true);
        //}
        //else
        //{
        //    animator.SetBool("walkRight", false);
        //}
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // AssaultRifle.gameObject.SetActive(false);
            animator.SetBool("run", true);
        }
        else
        {
            //AssaultRifle.gameObject.SetActive(true);
            animator.SetBool("run", false);
        }
        //////////////if (Input.GetKey(KeyCode.Q))
        //////////////{
        //////////////    // AssaultRifle.gameObject.SetActive(false);
        //////////////    animator.SetBool("bomb", true);
        //////////////    ///Gun.SetActive(false);
        //////////////}
        //////////////else
        //////////////{
        //////////////    //AssaultRifle.gameObject.SetActive(true);
        //////////////    animator.SetBool("bomb", false);
        //////////////    ///Gun.SetActive(true);
        //////////////}
        if (Input.GetKey(KeyCode.LeftControl))
        {
            animator.SetBool("crouch", true);
            ///GetComponent<Movement>().enabled = false;
           // GetComponent<Playerrr>().enabled = false;
        }
        else
        {
            animator.SetBool("crouch", false);
            ///GetComponent<Movement>().enabled = true;
            //GetComponent<Playerrr>().enabled = true;
        }
        //////if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.W))
        //////{
        //////    animator.SetBool("crouchW", true);
        //////}
        //////else
        //////{
        //////    animator.SetBool("crouchW", false);
        //////}
        if (Input.GetKey(KeyCode.Mouse0))
        {
            animator.SetBool("fire", true);
        }
        else
        {
            animator.SetBool("fire", false);
        }
        //////if (Input.GetKey(KeyCode.Mouse1))
        //////{

        //////    //ZoomCamera.SetActive(true);
        //////    //GlavnaCamera.SetActive(false);
        //////    animator.SetBool("firePripere", true);
        //////}
        //////else
        //////{
        //////    //ZoomCamera.SetActive(false);
        //////    //GlavnaCamera.SetActive(true);
        //////    animator.SetBool("firePripere", false);
        //////}
        if (Input.GetMouseButton(1))
        {
            GlavnaCamera.fieldOfView = (defaultFov / 2);
        }
        else
        {
            GlavnaCamera.fieldOfView = (defaultFov);
        }
        if (Input.GetKey(KeyCode.R))
        {

            animator.SetBool("reload", true);
        }
        else
        {
            animator.SetBool("reload", false);
        }

    }
}