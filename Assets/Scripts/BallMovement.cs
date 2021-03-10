using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rb;
    public int speed = 5;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gem")
        {
            Destroy(other.gameObject);
        }
    }
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        rb.AddForce(new Vector3(horizontal, 0, vertical)*speed);
    }
}
