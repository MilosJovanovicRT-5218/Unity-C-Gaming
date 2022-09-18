using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController characterController;

    Animator animator;


    private float verticalVelocity;
    public float runSpeed = 15.0f;
    public float speed = 6.0f;
    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;
    public float rotationSpeed = 60.0f;
    private Vector3 rotation;
    /// <summary>
    /// 
    /// </summary>
    ///private Vector3 jump2;
    /// <summary>
    /// 
    /// </summary>
    private Vector3 moveDirection = Vector3.zero;

    private float ySpeed;

    //public float NumberJumps = 0f;
    ///public Vector3 jump;

    public float jumpforce = 12f;
    Rigidbody rb;

    void Start()
    {
       /// jump = new Vector3(0.0f, 2.0f, 0.0f);

        characterController = GetComponent<CharacterController>();

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {

        if (characterController.isGrounded)
        {


            // We are grounded, so recalculate
            // move direction directly from axes

            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            //moveDirection *= speed;
            this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);

            Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
            move = this.transform.TransformDirection(move);
            characterController.Move(move * speed);
            this.transform.Rotate(this.rotation);

            ySpeed += Physics.gravity.y * Time.deltaTime;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;


                //rb.AddForce(transform.up * jumpSpeed);

                ///rb.AddForce(Vector3.up * jumpforce);
                //rb.AddForce(jump * jumpForce, ForceMode.Impulse);

                // jumpSpeed

                // NumberJumps += 1;

                // characterController.Move(move * jumpSpeed);

            }



            if (Input.GetKey(KeyCode.LeftShift))
            {
                //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                //  moveDirection *= runSpeed;
                characterController.Move(move * runSpeed);

            }
                //if (Input.GetKeyDown(KeyCode.W))
                //{
                //    animator.SetBool("pravo", true);
                //}


            }

            // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
            // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
            // as an acceleration (ms^-2)
            moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);


    }
}
//////////////public float _speed = 10;
//////////////public float _rotationSpeed = 180;
//////////////public float gravity = 20.0f;
//////////////private Vector3 rotation;

//////////////public void Update()
//////////////{
//////////////    if (characterController.isGrounded)
//////////////    {

//////////////        this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
//////////////        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
//////////////        move = this.transform.TransformDirection(move);
//////////////        characterController.Move(move * _speed);
//////////////        this.transform.Rotate(this.rotation);
//////////////    }
//////////////    moveDirection.y -= gravity * Time.deltaTime;
//////////////}