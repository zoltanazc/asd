using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component, called rb.
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    // We made it "Fixed" Update, because we are using it to mess with physics.
    void FixedUpdate()
    {
        // Add a forward force. Time.deltaTime -> It will be the same on all computer regardless of framerate.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d") )
        {   
            //VelocityChange, Forcemode is for changing directions easier.
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
