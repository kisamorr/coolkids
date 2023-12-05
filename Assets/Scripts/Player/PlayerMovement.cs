using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public PlayerInputActions playerControls;
    private InputAction move;
    private InputAction jump;
    private InputAction look;
    private Vector3 moveDirection;

    private CharacterController controller;
    private PlayerLook looking;

    private Vector2 movement;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float gravity = -20f;
    public float speed = 10f;
    public float runSpeed = 15f;
    public float jumpHeight = 6f;
    public Animator animator;

    private void Awake()
    {
        playerControls = new PlayerInputActions();
        looking = GetComponent<PlayerLook>();
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();

        look = playerControls.Player.Look;
        look.Enable();

        jump = playerControls.Player.Jump;
        jump.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        look.Disable();
        jump.Disable();
    }

    private void Update()
    {
        isGrounded = controller.isGrounded;
        
        if (isGrounded )
        {
            animator.SetBool("Idle", true );
        }

        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }

        if (jump.IsPressed())
        {
            Jump();
        }

        if (move.IsPressed() && isGrounded)
        {
            animator.SetBool("Idle", false);

            if (Input.GetKey(KeyCode.W))
            {
                animator.SetTrigger("back");
            }
            if (Input.GetKey(KeyCode.S))
            {
                animator.SetTrigger("front");
            }
            if (Input.GetKey(KeyCode.D))
            {
                animator.SetTrigger("right");
            }
            if (Input.GetKey(KeyCode.A))
            {
                animator.SetTrigger("left");
            }
        }
    }
    private void LateUpdate()
    {
        looking.ProcessLook(look.ReadValue<Vector2>());
    }
    void FixedUpdate()
    {
        movement = move.ReadValue<Vector2>();
        moveDirection = Vector3.zero;
        moveDirection.x = movement.x;
        moveDirection.z = movement.y;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(transform.TransformDirection(moveDirection) * runSpeed * Time.deltaTime);
        }

        else
        {
            controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        }

        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void Jump()
    {
        if (isGrounded)
        {
            playerVelocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
        }
    }
}
