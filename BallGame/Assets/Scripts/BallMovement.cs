using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;

    // marked this with fixedUpdate becaus; iam using it to mess with the physics.
    void FixedUpdate()
    {
        // add force 2000 to the Z axis
        rb.AddForce(0, 0, 2000 * Time.deltaTime);

    }
}
