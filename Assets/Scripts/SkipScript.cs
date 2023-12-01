using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButton : MonoBehaviour
{
    private void Start()
    {
        // Ensure that the button is interactable from the beginning
        GetComponent<UnityEngine.UI.Button>().interactable = true;
    }

    public void SkipIntro()
    {
        // Find the IntroTransition script in the scene
        introTransition introTransition = FindObjectOfType<introTransition>();

        if (introTransition != null)
        {
            // Set delayInSeconds to 0 in IntroTransition script
            introTransition.delayInSeconds = 0f;
        }

        // Move to Scene 1 immediately
        SceneManager.LoadScene("level1");
    }
}
