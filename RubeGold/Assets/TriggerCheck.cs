using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    public bool isTriggered;
    public void OnTriggerEnter(Collider other)
    {

         if (other.tag == "Player")
            isTriggered = true;
    }
}
