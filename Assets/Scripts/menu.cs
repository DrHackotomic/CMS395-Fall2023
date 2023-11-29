using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartLevel()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RestartGame()
    {
        // Reload the first scene in the build settings
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        // Quit the application (only works in builds, not in the Unity Editor)
        Application.Quit();
    }
}
