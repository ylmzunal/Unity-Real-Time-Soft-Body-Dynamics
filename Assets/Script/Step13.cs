using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step13 : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        
        // Play the audio clip
        audioSource.Play();
    }
}
