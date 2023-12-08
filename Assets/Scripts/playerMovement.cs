using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerMovement : MonoBehaviour
{
    // Speed
    private float currentSpeed;
    public float walkingSpeed = 7.5f;
    public float runningSpeed = 15f;
    public float slidingSpeed = 12f;
    public float crouchingSpeed = 5f;

    public Rigidbody rb;
    public float jumpSpeed;

    // Gravity
    public float gravity = -0.075f;
    private float baseLineGravity;

    // Move
    private float moveX;
    private float moveZ;
    private Vector3 move;

    // Other Stuff
    public CharacterController characterController;

    // Shitty Crouch Mechanics
    public CharacterController PlayerHeight;
    public float normalHeight, crouchHeight;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = walkingSpeed;
        baseLineGravity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * currentSpeed * Time.deltaTime;
        moveZ = Input.GetAxis("Vertical") * currentSpeed * Time.deltaTime;

        move = transform.right*moveX+
            transform.up*gravity+
            transform.forward*moveZ;

        characterController.Move(move);

        //if (Input.GetKey(KeyCode.C)) // Crouching
        //{
        //    PlayerHeight.height = crouchHeight;
        //    currentSpeed = crouchingSpeed;
        //}

        if (Input.GetKey(KeyCode.LeftShift)) // Sprinting
        {
            currentSpeed = runningSpeed;
        }

        else if (Input.GetKey(KeyCode.LeftControl)) // Sliding
        {
            currentSpeed = slidingSpeed;
            PlayerHeight.height = crouchHeight;
        }

        else // Normal Walking & Normal Height
        {
            PlayerHeight.height = normalHeight;
            currentSpeed = walkingSpeed;
        }

        if (characterController.isGrounded && Input.GetButtonDown("Jump"))
        {
            gravity = baseLineGravity;
            gravity *= -jumpSpeed;
        }
        if (gravity > baseLineGravity)
        {
            gravity -= 2 * Time.deltaTime;
        }
    }
}
