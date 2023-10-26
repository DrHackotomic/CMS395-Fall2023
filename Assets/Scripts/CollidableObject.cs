using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
    private Collider2D collider;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    [SerializeField]
    private ContactFilter2D filter;
    private List<Collider2D> collidedObjects;


    private void Start()
    {
        collider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        collider.OverlapCollider(filter, collidedObjects);
        foreach(var o in collidedObjects)
        {
            Debug.Log("Collided with" + o.name);
        }
    }
}
