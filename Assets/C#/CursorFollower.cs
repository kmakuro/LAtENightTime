using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CursorFollower : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Get the mouse position in screen space
        Vector3 mousePosition = Input.mousePosition;

        // Convert the screen space position to world space
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 0.1f));

        // Move the object to the cursor's world position
        transform.position = worldPosition;
    }
}
