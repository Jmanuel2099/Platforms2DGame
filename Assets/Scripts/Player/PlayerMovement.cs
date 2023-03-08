using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [Header("Move")]
    // private float horizontalMovement = 0f;
    [SerializeField] private float movementSpeed = 2f;
    // [SerializeField] private float moveSpeed = 400f;
    // [Range(0, 0.3)][SerializeField] private float smoothedMovement;
    // private Vector3  velocityAxisZ = Vector3.zero;
    // private bool lookingRight = true;

    [Header("Jump")]
    [SerializeField] private float jumpSpeed;

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // // Update is called once per frame
    // private void Update()
    // {
    //     // Left: -1  Right: 1
    //     horizontalMovement = Input.GetAxisRaw("Horizontal") * movementSpeed;

    // }

    //FixedUpdate method is mainly used for physics change
    private void FixedUpdate()
    {
        // Move(horizontalMovement * Time.fixedDeltaTime);
        Move();
    }

    // private void Move(float move)
    private void Move()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(movementSpeed, rb2d.velocity.y);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-movementSpeed, rb2d.velocity.y);
        }
        else if ((Input.GetKey("w") || Input.GetKey("up")) && CheckGround.isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        //     Vector3 targetVelocity = new Vector2(move, rb2d.velocity.y);
        //     rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, targetVelocity, ref velocityAxisZ, smoothedMovement);

        //     if (move > 0 && !lookingRight)
        //     {
        //         rotate();

        //     }else if (move < 0 && lookingRight)
        //     {
        //         rotate();
        //     }
    }

    // private void rotate()
    // {
    //     lookingRight = !lookingRight;
    //     Vector3 scale = transform.localScale;
    //     scale.x *= -1;
    //     transform.localScale = scale;
    // }

    private void Jump()
    {

    }
}

