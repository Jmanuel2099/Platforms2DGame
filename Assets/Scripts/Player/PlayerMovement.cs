using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [Header("Move")]
    [SerializeField] private float movementSpeed = 2f;

    [Header("Jump")]
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float doubleJumpSpeed;

    private bool canDoubleJump;
    // [SerializeField] private bool isBetterJump;
    // private float lowJumpMultiplier = 1f;
    // private float fallJumpMultiplier = 0.5f;

    [Header("Animations")]
    [SerializeField] private SpriteRenderer spriteRenderer;//help us with animations when we want to turn 
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        makeJump();
    }

    //FixedUpdate method is mainly used for physics change
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(movementSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("isRun", true);
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-movementSpeed, rb2d.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("isRun", true);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("isRun", false);
        }
        // if (isBetterJump)
        // {
        //     JumpBetter();
        // }
    }

    private void makeJump()
    {
        if (Input.GetKey("w") || Input.GetKey("up")) 
        {
            if (CheckGround.isGrounded)
            {
                canDoubleJump = true;
                rb2d.velocity = new Vector2(rb2d.velocity.x, jumpSpeed);
            }
            else
            {
                if ((Input.GetKeyDown("w") || Input.GetKeyDown("up")) && canDoubleJump)
                {
                    animator.SetBool("DoubleJump", true);
                    rb2d.velocity = new Vector2(rb2d.velocity.x, doubleJumpSpeed);
                    canDoubleJump = false;
                }    
            }
            
        }

        if (!CheckGround.isGrounded)
        {
            animator.SetBool("isJump", true);
            animator.SetBool("isRun", false);
        }
        if (CheckGround.isGrounded)
        {
            animator.SetBool("DoubleJump", false);
            animator.SetBool("isJump", false);
            animator.SetBool("Falling", false);
        }

        if (isFalling())
        {
            animator.SetBool("Falling", true);
        }
        else if (!isFalling())
        {
            animator.SetBool("Falling", false);
        }
    }

    private bool isFalling()
    {
        return rb2d.velocity.y < 0;
    }

    // private void JumpBetter()
    // {
    //     if (rb2d.velocity.y < 0)
    //     {
    //         rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallJumpMultiplier) * Time.deltaTime;
    //     }
    //     if (rb2d.velocity.y > 0 && (!Input.GetKey("up") || Input.GetKey("w")))
    //     {
    //         rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier) * Time.deltaTime;
    //     }
    // }

}

