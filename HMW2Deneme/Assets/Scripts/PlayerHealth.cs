using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100.0f; // Total player health

    public void TakeDamage(float amount)
    {
        health -= amount;
        Debug.Log($"Player health: {health}");
        if (health <= 0)
        {
            Debug.Log("Player is dead!");
        }
    }
}
