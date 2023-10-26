using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;

    private void Start()
    {
        LoadHealth();
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            playerSr.enabled = false;
            playerMovement.enabled = false;
        }
    }

    public void SaveHealth()
    {
        PlayerPrefs.SetInt("PlayerHealth", currentHealth);
    }

    public void LoadHealth()
    {
        if (PlayerPrefs.HasKey("PlayerHealth"))
        {
            currentHealth = PlayerPrefs.GetInt("PlayerHealth");
        }
    }

    }

