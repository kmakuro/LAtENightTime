using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
 public TextMeshProUGUI timerText;
    private float startTime;
    
    private ScoreManager scoreManager;
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
       
        float elapsedTime = Time.time*3 - startTime;
        int initialMinutes = 19; // Set the initial minute value
        int minutes = initialMinutes + (int)(elapsedTime / 60f);
        int seconds = (int)(elapsedTime % 60f);
        timerText.text = "Time: " + minutes.ToString("D2") + ":" + seconds.ToString("D2");



      /*   if (minutes == 22 && seconds == 00)
                {
                    EndGame();
                }
            */
       
    }
    public void EndGame()
    {
        // Load the end scene

       
        SceneManager.LoadSceneAsync(0);
    }
    
}
