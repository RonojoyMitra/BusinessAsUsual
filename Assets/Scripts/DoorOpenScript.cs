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
    public AudioSource doorAud;
    public AudioClip doorOpening;
    public AudioClip doorClosing;

    // Start is called before the first frame update
    void Start()
    {
        doorAud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DoorOpened()
    {
        doorOpened = true;
        thisRigidbody.AddTorque(openingTorque);
        doorAud.PlayOneShot(doorOpening);
    }

    void DoorClosed()
    {
        doorOpened = false;
        thisRigidbody.AddTorque(closingTorque);
        doorAud.PlayOneShot(doorClosing);
    }
}
