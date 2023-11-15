using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chest : MonoBehaviour
{
    //private Animator anim;
    private bool isOpen;
    private AudioSource audioSource;
    public AudioClip boop;
    public float volume = 0.25f;

    private void Start()
    {
        //anim.GetComponent<Animator>();
    }

    void onTriggerEnter2D (Collision2D collision)
    {
        if(collision.gameObject.CompareTag("player") && !isOpen)
        {
            OpenChest();
            GetComponent<AudioSource>().PlayOneShot(boop, volume);
        }
    }

    void OpenChest()
    {
        //anim.SetTrigger("Open");
        isOpen = true;
        Debug.Log("Chest Opened!");
        
    }


}