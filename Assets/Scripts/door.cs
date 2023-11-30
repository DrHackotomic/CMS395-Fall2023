using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string nextSceneName; // Name of the next scene to load
    public HealthSystem healthSystem;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player") && gameManager.IsChestOpen) // Check if the player enters the trigger zone and the chest is open
        {
            healthSystem.LoadHealth();
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        gameManager.ResetChestState(); // Reset chest state in GameManager
        SceneManager.LoadScene(nextSceneName);
    }
}
