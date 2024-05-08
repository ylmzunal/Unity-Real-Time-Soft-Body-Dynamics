using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for loading and unloading scenes

public class GameEndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish")) // Ensure that only collisions with the tagged "Finish" object trigger the game end
        {
            Debug.Log("Game Over! Player has reached the finish line.");
            EndGame();
        }
    }

    void EndGame()
    {
        // Load a new scene or reload the current scene
        SceneManager.LoadScene("GameOverScene"); // Make sure "GameOverScene" is added in your build settings
    }
}

