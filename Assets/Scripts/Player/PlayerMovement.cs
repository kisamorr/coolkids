using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;                  // A reference to the main camera in the scenes transform

    public PlayerInputActions playerControls;
    private InputAction move;
    private InputAction jump;
    private InputAction look;
    private Vector3 moveDirection;

    private PlayerLook looking;

    private Vector2 movement;
    private Vector3 playerVelocity;
    private bool isGrounded;
    public float speed = 10f;
    public float runSpeed = 15f;
    public float jumpHeight = 6f;


    //
    public float turnSmoothTime = 0.1f;

    float turnSmoothVelocity;

    //public Vector3 moveDir;
    //public Vector3 _movement;

    [Header("Gravity")]
    public float gravity = -20f;
    public float constantGravity = 0.6f;
    public float maxGravity = -15;

    private float currentGravity;
    private Vector3 gravityDirection = Vector3.down;
    private Vector3 gravityMovement;


    public ContactPoint[] contacts;

    public Animator animator;

    private void Awake()
    {
        playerControls = new PlayerInputActions();
        looking = GetComponent<PlayerLook>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Camera.main != null)
        {
            cam = Camera.main.transform;
        }
        else
        {
            Debug.LogWarning(
                "Warning: no main camera found. Character needs a camera tagged \"MainCamera\", for camera-RelativeJoint2D controls.", gameObject);
        }

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

    // Update is called once per frame
    void Update()
    {
        isGrounded = controller.isGrounded;

        if (isGrounded && playerVelocity.y < 0)
        {
            playerVelocity.y = -2f;
        }

        if (jump.IsPressed())
        {
            Jump();
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



        // player needs to FACE the direction of the transformation belwo

        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(transform.TransformDirection(moveDirection) * runSpeed * Time.deltaTime);
        }

        else
        {
            controller.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        }

        if (moveDirection != Vector3.zero)
        {
            Vector3 dir;

            dir = transform.TransformDirection(moveDirection);
            dir.y = 0;

            transform.rotation = Quaternion.LookRotation(dir);

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

    private void OnColliderEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ladder")
        {
            print("collided with ladder");
        }
        /*if (collision.gameObject.tag == "Ladder" && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space))
        {
            print("collided with ladder");
            ContactPoint contact = collision.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            gameObject.transform.rotation *= rot;
        }*/
    }
}
