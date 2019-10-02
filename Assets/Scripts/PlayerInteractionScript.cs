using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionScript : MonoBehaviour
{
    public GameObject door;

    public bool isCloseToDoor;
    public bool doorIsOpened;
    public bool ShutDoor;
    // Update is called once per frame
    public float doorRotation;
    void Update()
    {
        Ray PlayerRay = new Ray(transform.position, transform.forward);
        float maxRayDistance = 3f;
        Debug.DrawRay(PlayerRay.origin,PlayerRay.direction * maxRayDistance,Color.green);
        doorRotation = door.transform.localEulerAngles.y;
        RaycastHit PlayerHit = new RaycastHit();
        //if (Vector3.Distance(transform.position, door.transform.position) < 10f)
        //{
        //    isCloseToDoor = true;
        //}
        if (PlayerHit.transform == null)
        {
            Debug.Log("SettingIsclosetoDoor to false");
            isCloseToDoor = false;
        }
        if (Physics.Raycast(PlayerRay, out PlayerHit, maxRayDistance))
        {
            
            if (PlayerHit.transform != null && PlayerHit.transform.tag == "Door")
            {
                Debug.Log("settingIsCloseToDoor to true");
                isCloseToDoor = true;
            }
            
        }
        //if (Vector3.Distance(transform.position, door.transform.position) > 10f)
        //{
        //    isCloseToDoor = false;
        //}

        if (doorRotation <= 118 && doorIsOpened == false && door.GetComponent<DoorOpenScript>().Opened == false && isCloseToDoor && Input.GetKeyDown(KeyCode.F))
        {
            doorIsOpened = true;
            Debug.Log("Opening Door");
            door.SendMessage("DoorOpened");
            ShutDoor = false;
        }
        if (doorRotation > 118 && Input.GetKeyDown(KeyCode.F) && isCloseToDoor)
        {
            {
                Debug.Log("DoorisClosed");
                door.SendMessage("DoorClosed");
                doorIsOpened = false;
                ShutDoor = true;
            }
        }

    }
}
