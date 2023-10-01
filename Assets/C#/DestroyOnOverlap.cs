using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnOverlap : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>(); // Find the ScoreManager in the scene
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Doll"))
        {
            Destroy(collision.gameObject);
            if (scoreManager != null)
            {
                scoreManager.AddScore(10); // Increment the score by 10 when a "Doll" is destroyed
            }
        }
    }
}
