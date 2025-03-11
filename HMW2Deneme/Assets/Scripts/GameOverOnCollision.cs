using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Needed for manipulating UI elements

public class GameOverOnCollision : MonoBehaviour
{
    public string targetObjectName; // Name of the object to collide with
    public GameObject gameOverText; // Assign the UI Text GameObject here

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == targetObjectName)
        {
            gameOverText.SetActive(true); // Show the game over text
            Time.timeScale = 0; // Stop the game
        }
    }
}
