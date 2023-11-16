using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chest : MonoBehaviour
{

    public GameObject chestClose, chestOpen;
    //private Animator anim;
    private bool isOpen;
    private bool playerInZone;

    private void Start()
    {
        //anim.GetComponent<Animator>();
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

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        {
            OpenChest();
            playerInZone = true;
            chestClose.SetActive(false);
            chestOpen.SetActive(true);
        }
    }

    void OpenChest()
    {
        //anim.SetTrigger("Open");
        isOpen = true;
        Debug.Log("Chest Opened!");
    }


}