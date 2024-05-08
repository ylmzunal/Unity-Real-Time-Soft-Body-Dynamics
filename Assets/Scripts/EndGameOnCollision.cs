using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Include this if you need to load a different scene on collision

public class EndGameOnCollision : MonoBehaviour
{
    public string targetObjectName; // Set this to the name of the object to detect collision with

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == targetObjectName)
        {
            Debug.Log("Collision detected with " + targetObjectName);
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        // Add your game over logic here
        // For example, load a new scene or display a game over screen
        // SceneManager.LoadScene("GameOverScene");
    }
}

