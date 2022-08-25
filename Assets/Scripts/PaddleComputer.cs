using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleComputer : MonoBehaviour
{

    public Rigidbody2D ball;

    public float paddleSpeed = 15f;

    private Rigidbody2D rb;
    private Vector2 movementDirection;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0){ // if the ball is moving towards the computer paddle, then the paddle should try and intercept the ball

            if(ball.position.y > transform.position.y)
            {
                rb.AddForce(Vector2.up * paddleSpeed);
            }
            else if(ball.position.y < transform.position.y)
            {
                rb.AddForce(Vector2.down * paddleSpeed);
            }
            else 
            {
                rb.AddForce(Vector2.zero * paddleSpeed);
            }
        }
    }
    
}
