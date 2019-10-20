using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorManagerScript : MonoBehaviour
{
    public List<GameObject> visitors;
    int currentVisitor = 0;
    public VisitorScript currentVisitorScript;
    public AudioSource endAud;
    //public GameObject Player;

    private void Start()
    {
        currentVisitorScript = visitors[0].gameObject.GetComponent<VisitorScript>();
        currentVisitorScript.visitorSequenceState = 0;
    }

    

    public void InitializeNextVisitor()
    {
        if (currentVisitor < visitors.Count)
        {
            //Send Next Visitor to Door
            currentVisitorScript = visitors[currentVisitor].gameObject.GetComponent<VisitorScript>();
            currentVisitorScript.visitorSequenceState = 0;
        }
        else
        {
            Debug.Log("End Game");
            endAud.Play();
            //Player.SendMessage("End"); 
            StartCoroutine(ExecuteAfterTime(8));
        }
        IEnumerator ExecuteAfterTime(float Time)
        {
            Debug.Log("Enters end Coroutine");
            yield return new WaitForSeconds(Time);
            Application.Quit();
        }
    }

    public void VisitorIncrement()
    {
        currentVisitor++;
    }


}
