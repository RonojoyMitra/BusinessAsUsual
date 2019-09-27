using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    public Rigidbody thisRigidbody;
    public Vector3 startingTorque;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody.AddTorque(startingTorque);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
