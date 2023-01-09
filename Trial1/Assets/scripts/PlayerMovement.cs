
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // create variable visible in the inspector 
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    // I am using the FixedUpdate (instead of the Update) because I am using it to mess with physics
    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
                {
                    rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
                }

    }
}
