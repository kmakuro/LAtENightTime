using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class Sceneshotinh : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI m_InteractionTxt;
    public string sceneToLoad; // Name of the scene you want to load.

    private bool canChangeScene = false;

    private void Update()
    {
        if (canChangeScene && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneToLoad,LoadSceneMode.Additive);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player (or has a specific tag).
        if (other.CompareTag("Player"))
        {
            m_InteractionTxt.gameObject.SetActive(true);
            canChangeScene = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger is the player (or has a specific tag).
        if (other.CompareTag("Player"))
        {
            m_InteractionTxt.gameObject.SetActive(false);
            canChangeScene = false;
        }
    }
}

