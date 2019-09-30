using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    public Rigidbody thisRigidbody;
    public Vector3 startingTorque;
    public bool Opened = false;

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
        Opened = true;
        thisRigidbody.AddTorque(startingTorque);
    }

    void DoorClosed()
    {
        Opened = false;
        thisRigidbody.AddTorque(-startingTorque);
    }
}
