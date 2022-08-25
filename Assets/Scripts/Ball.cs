using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 250f;

    private Rigidbody2D rb;
    private float xDirection;
    private float yDirection;
    private Vector2 ballDirection;
    private Vector2 originalPosition;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Start()
    {
        originalPosition = new Vector2(transform.position.x, transform.position.y);
        Serve();
    }

    private void Serve()
    {
        if(Random.value > 0.5f)
        {
            xDirection = 1f;
        }
        else
        {
            xDirection = -1f;
        }
        
        yDirection = Random.Range(-1f, 1f);
        ballDirection = new Vector2(xDirection, yDirection);

        rb.AddForce(speed * ballDirection);

    }

    public void ResetBallPosition()
    {
        transform.position = originalPosition;
        rb.velocity = originalPosition;
        Serve();
    }

}
