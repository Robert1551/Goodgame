using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
        rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
