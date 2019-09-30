using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, door.transform.position) < 10f && Input.GetKey(KeyCode.F))
        {
            Debug.Log("DoorisOpened");
            door.SendMessage("DoorOpened");
        }

        //if (Vector3.Distance(transform.position, door.transform.position) < 10f && Input.GetKey(KeyCode.F) && door.GetComponent<DoorOpenScript>().Opened == true)
        //{
        //    Debug.Log("DoorisClosed");
        //    door.SendMessage("DoorClosed");
        //}
    }
}
