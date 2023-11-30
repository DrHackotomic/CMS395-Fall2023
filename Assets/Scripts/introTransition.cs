using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class introTransition : MonoBehaviour
{

    public string nextLevelName = "level1";
    public float delayInSeconds = 3f;

    private bool canLoadNextLevel = false;

    private void Start()
    {
    
        // Start the timer to enable the trigger after the specified delay
        Invoke("EnableLoadNextLevel", delayInSeconds);
        Debug.Log("delay started");
    }

    private void EnableLoadNextLevel()
    {
      
        // Enable the trigger to load the next level
        canLoadNextLevel = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (canLoadNextLevel && collision.CompareTag("player"))
        {
            // Player has collided with the triggerable boundary, load the next level
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
