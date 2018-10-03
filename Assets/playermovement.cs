using UnityEngine;

public class playermovement : MonoBehaviour {

    public Rigidbody rb;

    public float movementforce = 500f;
	
	// Update is called once per frame
	void FixedUpdate ()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(movementforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-movementforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, movementforce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -movementforce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
