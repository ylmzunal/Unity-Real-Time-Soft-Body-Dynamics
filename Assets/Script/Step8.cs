using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step8 : MonoBehaviour
{
    public GameObject prefabToSpawn; // Drag and drop your prefab in the Inspector
    public KeyCode spawnKey = KeyCode.Space; // Change this to any key you want to use for spawning

    void Update()
    {
        // Check if the spawn key is pressed
        if (Input.GetKeyDown(spawnKey))
        {
            // Spawn a new object from the prefab at the position of this GameObject
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}
