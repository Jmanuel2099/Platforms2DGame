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

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
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
    }

}

