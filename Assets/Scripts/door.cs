using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string nextSceneName; // Name of the next scene to load
    public HealthSystem healthSystem;
    public static bool chestCollided = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player")) // Check if the player enters the trigger zone
        {
            if (Chest.chestCollided)
            {
                healthSystem.LoadHealth();
                LoadNextScene();

            }

        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
