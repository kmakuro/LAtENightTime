using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour

{
    public float destroyDelay = 1.0f; // Time in seconds before destroying the object

    void Start()
    {
        // Start a coroutine to destroy the object after a delay
        StartCoroutine(DestroyObjectDelayed());
    }

    IEnumerator DestroyObjectDelayed()
    {
        // Wait for the specified delay time
        yield return new WaitForSeconds(destroyDelay);

        // Destroy the object
        Destroy(gameObject);
    }
}

