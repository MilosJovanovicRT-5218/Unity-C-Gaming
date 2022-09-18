using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
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
    private Vector3 moveDirection = Vector3.zero;



    public float jumpforce = 10f;
    Rigidbody rb;

    void Start()
    {
        characterController = GetComponent<CharacterController>();

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (characterController.isGrounded)
        {   
            this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);

            Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
            move = this.transform.TransformDirection(move);
            characterController.Move(move * speed);
            this.transform.Rotate(this.rotation);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
                // characterController.Move(move * jumpSpeed);

            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                //  moveDirection *= runSpeed;
                characterController.Move(move * runSpeed);

            }
        }
        moveDirection.y -= gravity * Time.deltaTime;

       
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
