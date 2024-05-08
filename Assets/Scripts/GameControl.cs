using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Needed for loading scenes

public class GameControl : MonoBehaviour
{
    public void RestartGame()
    {
        Time.timeScale = 1; // Resume the normal game speed
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload the current scene
    }

    public void ExitGame()
    {
        Application.Quit(); // Quit the game
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing in the editor
        #endif
    }
}


