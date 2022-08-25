using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Scores : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            GameManager.Instance.player2Scores();
        }
    }
}
