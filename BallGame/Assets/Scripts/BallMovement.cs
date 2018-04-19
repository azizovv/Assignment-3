using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;

    // marked this with fixedUpdate becaus; iam using it to mess with the physics.
    void FixedUpdate()
    {
        // add force 2000 to the Z axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("l"))
        {

            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))

        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0);
        }
        
    }
}
