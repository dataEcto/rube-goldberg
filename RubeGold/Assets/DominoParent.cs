using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoParent : MonoBehaviour
{
    private Transform _dominoParent;
    private GameObject _dominoOne;
    private bool dropDominoes = false;
    

    void Start()
    {
        _dominoParent = GameObject.Find("Ghost").GetComponent<Transform>();
        _dominoOne = GameObject.FindGameObjectWithTag("GameController");
        //Go through the child of the object (In this case, the dominoes
        //and set their rigidbody kinematic components to true
        foreach (Transform child in _dominoParent)
        {
            if (child.GetComponent<Rigidbody>())
            {
                child.GetComponent<Rigidbody>().isKinematic = true;
            }
        }
        
     
    }

    private void Update()
    {
        if (_dominoOne.GetComponent<TriggerCheck>().isTriggered)
        {
            DropDominoes();
        }
           

     
    }



    void DropDominoes()
    {
        
        foreach (Transform child in _dominoParent)
        {
            if (child.GetComponent<Rigidbody>())
            {
                child.GetComponent<Rigidbody>().isKinematic = false;
                child.GetComponent<Rigidbody>().AddForce(Vector3.down);
            }
        }
        
       
    }
}
