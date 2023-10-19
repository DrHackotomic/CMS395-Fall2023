using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAndFallController : MonoBehaviour
{
    //public float jumpForce = 5.0f;      // Jump force (adjust as needed)
    //public float fallGravityMultiplier = 2.0f; // Adjust gravity multiplier for falling
    public float jumpAmount = 10;
    //private bool isGrounded;
    private Rigidbody2D rb;
    public bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        //// Check if the object is grounded using raycasting
        //isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        //// Check for jump input (e.g., Space key)
        //if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        //{
        //    // Apply an upward force to jump
        //    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        //}

        //// Apply gravity when not grounded
        //if (!isGrounded)
        //{
        //    rb.velocity += Vector2.up * Physics2D.gravity.y * (fallGravityMultiplier - 1) * Time.deltaTime;
        //}
    }

}


