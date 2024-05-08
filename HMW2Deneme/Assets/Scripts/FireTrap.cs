using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class FireTrap : MonoBehaviour
{
    public float activeTime = 3.0f;
    public float inactiveTime = 3.0f;

    void Start()
    {
        StartCoroutine(ActivateFire());
    }

    IEnumerator ActivateFire()
    {
        ParticleSystem fireParticles = GetComponent<ParticleSystem>();

        while (true)
        {
            fireParticles.Play(); // Start the fire
            yield return new WaitForSeconds(activeTime); // Fire burns for a while

            fireParticles.Stop(); // Stop the fire
            yield return new WaitForSeconds(inactiveTime); // Fire is off for a while
        }
    }
}


