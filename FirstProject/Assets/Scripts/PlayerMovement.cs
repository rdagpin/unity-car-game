using UnityEngine;

public class PlayerMovement : MonoBehaviour {


	public Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		
	}

	public float forwardForce = 500f;
	public float sidewaysForce = 500f;

	/* Update is called once per frame
	 * We are using this as "FixedUpdate" because
	 * are using it to mess with physics
	 */
	void FixedUpdate () 
	{
		// Add a forward force 
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d"))
		{
			// Will move to the right when 'd' is pressed
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}

		if(Input.GetKey("a"))
		{
			// Will move to the left when 'd' is pressed
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		} 
	}
}
