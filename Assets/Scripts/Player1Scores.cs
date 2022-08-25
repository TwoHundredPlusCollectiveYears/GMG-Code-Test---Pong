using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Scores : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            GameManager.Instance.player1Scores();
        }
    }
}
