using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingFunction : MonoBehaviour
{
    private Rigidbody _myRb;

    private AudioSource _myAs;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _myRb = GetComponent<Rigidbody>();
        _myAs = GetComponent<AudioSource>();

        _myRb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _myRb.isKinematic = false;
            _myAs.Play();
        }
    }
}
