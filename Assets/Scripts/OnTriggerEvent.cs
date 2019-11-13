using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;
    // Tag of object to check
    public string hitTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == hitTag)
        {
            // Invoke the event
            onEnter.Invoke();
        }
    }
}
