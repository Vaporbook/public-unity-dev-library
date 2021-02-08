using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour
{
    public CharacterController controller;
    
    private Vector3 playerVelocity;

    [Header("playerSpeed")]
    [Tooltip("Player speed factor")]
    [SerializeField] private float playerSpeed = 4.0f;

    [SerializeField] private float jumpHeight = 2.0f;
    [SerializeField] private float gravityValue = -9.81f;
    [SerializeField] private float rotationSpeed = 75;

    Vector3 currentEulerAngles;

    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        UpdateRotation();
        UpdateMove();
    }

    void UpdateRotation()
    {
        // Input.GetAxis("Horizontal") // right-left in FPPOV
        float horiz = Input.GetAxis("Horizontal");
        if (horiz != 0) { // L-R = rotation
            Vector3 turnInput = new Vector3(0, horiz, 0);
            currentEulerAngles += turnInput * Time.deltaTime * rotationSpeed;
            transform.eulerAngles = currentEulerAngles;
        }
    }

    void UpdateMove()
    {
        float vert = Input.GetAxis("Vertical");
        bool jump = Input.GetButtonDown("Jump");

        if (controller.isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        if (jump && controller.isGrounded)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;

        if (vert > 0) { // U-D = forward back
            controller.Move((transform.forward + playerVelocity) * Time.deltaTime * playerSpeed);
        } else if (vert < 0) {
            controller.Move(-1 * transform.forward * Time.deltaTime * playerSpeed);
        } else {
            controller.Move(playerVelocity * Time.deltaTime);
        }
    }
}

/*

        if (Input.GetKeyDown(KeyCode.X)) x = 1 - x;
        if (Input.GetKeyDown(KeyCode.Y)) y = 1 - y;
        if (Input.GetKeyDown(KeyCode.Z)) z = 1 - z;

        //modifying the Vector3, based on input multiplied by speed and time
        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotationSpeed;

        //apply the change to the gameObject
        transform.eulerAngles = currentEulerAngles;

*/