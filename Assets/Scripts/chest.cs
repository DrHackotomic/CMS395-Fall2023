using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Chest : MonoBehaviour
{
    //private Animator anim;
    private bool isOpen;

    private void Start()
    {
        //anim.GetComponent<Animator>();
    }

    void onTriggerEnter2D (Collision2D collision)
    {
        if(collision.gameObject.CompareTag("player") && !isOpen)
        {
            OpenChest();
        }
    }

    void OpenChest()
    {
        //anim.SetTrigger("Open");
        isOpen = true;
        Debug.Log("Chest Opened!");
    }


}