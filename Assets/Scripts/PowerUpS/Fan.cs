using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField]
    PlaneController plane;
    [SerializeField]
    float fanPower = 10;

    Rigidbody rb;

    private void Start()
    {
        plane = GameObject.Find("PaperPlane").GetComponent<PlaneController>();
        rb = plane.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(new Vector3(0, rb.velocity.y, 0) + (Vector3.up * fanPower), ForceMode.VelocityChange);
        }
    }
}
