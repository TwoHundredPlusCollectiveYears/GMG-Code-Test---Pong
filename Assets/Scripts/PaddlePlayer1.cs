using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer1 : MonoBehaviour
{
    public float paddleSpeed = 15f;

    private Rigidbody2D rb;
    private Vector2 movementDirection;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W)) 
        {
            movementDirection = Vector2.up; 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementDirection = Vector2.down; 
        }
        else
        {
            movementDirection = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(movementDirection.magnitude != 0)
        {
            rb.AddForce(paddleSpeed * movementDirection);

        }
    }


}
