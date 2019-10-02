using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorScript : MonoBehaviour
{
    public GameObject OutsidetheDoor;
    public GameObject Player;
    public float VMoveSpeed = 4f;
    public bool leave = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, OutsidetheDoor.transform.position, VMoveSpeed * Time.deltaTime);

        if (transform.position == OutsidetheDoor.transform.position)
        {
            Debug.Log("PlayDoorbell Sound");
            leave = true;
        }
        if(leave == true && Player.GetComponent<PlayerInteractionScript>().ShutDoor == true)
        {
            //todo fix logic 
        }
    }
}
