using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveForce = 10f;

	public float maxSpeed = 10f;

	void FixedUpdate()
	{
	    float moveX = Input.GetAxis("Horizontal");
	    float moveZ = Input.GetAxis("Vertical");

	    Vector3 movement = new Vector3(moveX, 0f, moveZ);

	    rb.AddForce(movement * moveForce);

	    if (rb.velocity.magnitude > maxSpeed)
	    {
	        rb.velocity = rb.velocity.normalized * maxSpeed;
	    }
	}
}