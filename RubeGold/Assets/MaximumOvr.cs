using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximumOvr : MonoBehaviour
{
    public float thrust;
    Rigidbody my_rb;
    // Start is called before the first frame update
    void Start()
    {
       my_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        my_rb.AddForce(transform.forward * thrust);
    }
}
