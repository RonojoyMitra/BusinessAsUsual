using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    public Rigidbody thisRigidbody;
    public Vector3 openingTorque;
    public bool doorOpened = false;
    public float doorRotation;
    public Vector3 closingTorque; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoorOpened()
    {
        doorOpened = true;
        thisRigidbody.AddTorque(openingTorque);
    }

    void DoorClosed()
    {
        doorOpened = false;
        thisRigidbody.AddTorque(closingTorque);
    }
}
