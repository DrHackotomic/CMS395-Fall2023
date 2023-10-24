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
        currentHealth = maxHealth;
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

    }

