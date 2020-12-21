using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_PlayerControl : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;

    public GameObject cam;
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * Input.GetAxis("Horizontal") * -speed/2);
        rb.AddForce(transform.right * Input.GetAxis("Vertical") * speed);
       
        transform.Rotate(transform.up * Input.GetAxis("Mouse X") * rotationSpeed);
        cam.transform.Rotate(Vector3.right * Input.GetAxis("Mouse Y") * -rotationSpeed);

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
