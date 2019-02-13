using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Camera myCamera;
    public Transform followtarget;
    bool followSphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followtarget != null && followSphere == true)
        {

            Vector3 newForwardDirection = followtarget.transform.position - myCamera.transform.position;
            myCamera.transform.forward = newForwardDirection;
            Debug.Log(myCamera.transform.position);
            Debug.Log("Following the Sphere");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Camera.main.enabled = false;
        myCamera.enabled = true;
        followSphere = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position,transform.localScale);

        if (myCamera != null)
        {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, myCamera.transform.position);
        }
    }
   
}
