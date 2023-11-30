using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public HealthSystem playerHealth;
    public int damage = 1;
    private AudioSource audioSource;
    public AudioClip boop;
    public float volume = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            // Null check for playerHealth
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
                // Use the cached audioSource variable
                audioSource.PlayOneShot(boop, volume);
            }
            else
            {
                Debug.LogError("Player health reference is null. Make sure to assign it in the Inspector.");
            }
        }
    }
}
