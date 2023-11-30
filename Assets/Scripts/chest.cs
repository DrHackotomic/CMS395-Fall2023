using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chestClose, chestOpen;
    private bool playerInZone;

    private void Start()
    {
        playerInZone = false;
        chestClose.SetActive(true);
        chestOpen.SetActive(false);
    }

    private void Update()
    {
        if (playerInZone && Input.GetMouseButtonDown(0))
        {
            OpenChest();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player") && !GameManager.instance.IsChestOpen)
        {
            // Check if the chest is not already open
            OpenChest();
            playerInZone = true;
            chestClose.SetActive(false);
            chestOpen.SetActive(true);
            GameManager.instance.IsChestOpen = true; // Update the chest state in GameManager
        }
    }

    void OpenChest()
    {
        // Your logic to open the chest
        // anim.SetTrigger("Open");
        Debug.Log("Chest Opened!");
    }
}
