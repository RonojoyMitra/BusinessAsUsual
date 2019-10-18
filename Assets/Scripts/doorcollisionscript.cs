using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcollisionscript : MonoBehaviour
{
    //SphereCollider collider = GetComponent<SphereCollider>();
    SphereCollider collider;
    // Start is called before the first frame update
    void Start()
    {
       collider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            Physics.IgnoreCollision(collision.collider,collider);
        }
    }
}
