using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorScript : MonoBehaviour
{
    public GameObject OutsidetheDoor;
    public GameObject Player;
    public GameObject mainDoor;
    public VisitorManagerScript visitorManagerScript;
    public float VMoveSpeed = 4f;
    public bool leave = false;
    public int visitorSequenceState = -1;
    public bool coroutineStarted = false;
    //-1 = visitor not active
    //0 = visitor walks up to door
    //1 = visitor waits
    //2 = visitor says his line
    //3 = visitor leaves 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (visitorSequenceState == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, OutsidetheDoor.transform.position, VMoveSpeed * Time.deltaTime);
        }
        if (transform.position == OutsidetheDoor.transform.position && visitorSequenceState == 0)
        {
            Debug.Log("PlayDoorbell Sound");
            visitorSequenceState = 1;
            leave = true;
            Debug.Log(visitorSequenceState);
            //1
        }
        if (mainDoor.transform.localEulerAngles.y > 118 && visitorSequenceState == 1)
        {
            visitorSequenceState = 2;
            Debug.Log("SayLine");
            Debug.Log(visitorSequenceState);
        }
        if (mainDoor.transform.localEulerAngles.y < 1 && visitorSequenceState == 2)
        {
            visitorSequenceState = 3;
            Debug.Log(visitorSequenceState);
        }
        if (visitorSequenceState == 3)
        {
            //visitorManagerScript.VisitorIncrement();
            //visitorManagerScript.InitializeNextVisitor();
            //this.gameObject.SetActive(false);
            //StopAllCoroutines();
            if (coroutineStarted == false)
            {
                StartCoroutine(ExecuteAfterTime(10));
                Debug.Log("Started Coroutine");
            }
        }
        //if(leave == true && Player.GetComponent<PlayerInteractionScript>().ShutDoor == true)
        //{
        //    //todo fix logic 
        //}
        IEnumerator ExecuteAfterTime(float time)
        {
            coroutineStarted = true;
            yield return new WaitForSeconds(time);
            Debug.Log("Coroutine ended");
            visitorManagerScript.VisitorIncrement();
            visitorManagerScript.InitializeNextVisitor();
            this.gameObject.SetActive(false);
            coroutineStarted = false;
        }
    }
}
