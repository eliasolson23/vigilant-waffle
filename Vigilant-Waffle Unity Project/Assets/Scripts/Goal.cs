using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Detects when the ball touches the goal, and then win the level.
/// </summary>
public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (collision.tag == "Player")
        {
            Debug.Log("Success!");
        }
    }

    
}
