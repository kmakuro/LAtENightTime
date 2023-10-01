using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCursor : MonoBehaviour
{
  
       public Texture2D defaultCursor; // The default cursor image
       public Texture2D shootingCursor; // The shooting cursor image
       private bool isShooting;
   
       void Start()
       {
           // Set the default cursor initially
           Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
       }
   
       void Update()
       {
           // Check for player shooting or interaction (e.g., left mouse button click)
           if (Input.GetMouseButtonDown(0)) // Change this condition based on your game logic
           {
               // Player is shooting, set the shooting cursor
               SetCursor(shootingCursor);
               isShooting = true;
           }
           else if (isShooting)
           {
               // Player has stopped shooting, set the default cursor
               SetCursor(defaultCursor);
               isShooting = false;
           }
       }
   
       private void SetCursor(Texture2D cursorTexture)
       {
           Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
       }
   }


