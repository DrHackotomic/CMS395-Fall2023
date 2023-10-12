using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactables : MonoBehaviour
{
    private void onCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chest"))
        {
            // open chest, gain item and open door
            Debug.Log("chest opened");
        } 
    }
}
