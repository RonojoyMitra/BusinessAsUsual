using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonControllerScript : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Vector3 inputVector;
    public Rigidbody thisRigidBody;
    public float mouseX;
    public float mouseY;
    // Start is called before the first frame update
    void Start()
    {
        thisRigidBody = GetComponent<Rigidbody>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0, mouseX, 0);
        Camera.main.transform.Rotate(-mouseY, 0, 0);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        inputVector = transform.forward * vertical;
        inputVector += transform.right * horizontal;
    }
    private void FixedUpdate()
    {
        thisRigidBody.velocity = inputVector * moveSpeed + Physics.gravity * 0.69f;
    }
}
