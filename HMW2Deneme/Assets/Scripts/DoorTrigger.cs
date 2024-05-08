using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // "Player" etiketi çarpışmayı tetiklemesi gereken nesne
        {
            animator.SetBool("isOpen", true);  // Kapıyı aç
        }
    }
}

