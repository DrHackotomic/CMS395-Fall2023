using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempboundary : MonoBehaviour
{
    public float delayInSeconds = 3f;

    private void Start()
    {
        // Invoke the method to make the object disappear after the specified delay
        Invoke("DisappearObject", delayInSeconds);
    }

    private void DisappearObject()
    {
        // Deactivate (make invisible) the GameObject
        gameObject.SetActive(false);
        Debug.Log("object gone teehee");
    }
}
