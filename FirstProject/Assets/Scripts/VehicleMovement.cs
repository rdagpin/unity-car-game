using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component calles "rb"
	public Rigidbody rb;
	public WheelCollider frontLeftWheel; 
	public WheelCollider frontRIghtWheel;
	public WheelCollider backLeftWheel;
	public WheelCollider backRightWheel;

	public Transform frontLeftWheelTransform; 
	public Transform frontRIghtWheeltTransform;
	public Transform backLeftWheeltTransform;
	public Transform backRightWheeltTransform;

	public Vector3 rotate;

	public float forwardForce = 500f;		// Variable determining forward force
	public float sidewaysForce = 500f;		// Variable determining sideward force


	// Update is called once per frame
	// We are using as "FixedUpdate" because we are using it to mess with physics
	void FixedUpdate () 
	{
		// This just makes the wheels spin, wheels does not actually affect player movement 
		if (10 < 11) 
		{

			frontLeftWheelTransform.Rotate(0,-30, 0);
			frontRIghtWheeltTransform.Rotate(0,-30, 0);
			backLeftWheeltTransform.Rotate(0,-30, 0);
			backRightWheeltTransform.Rotate(0,-30, 0);

		}


		// Add a forward force 
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d"))
		{
			// Will move to the right when 'd' is pressed
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		}

		if(Input.GetKey("a"))
		{
			// Will move to the left when 'a' is pressed
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

		} 

		// If the y position of the player is below -1 or the valoue is not a number then it will restart
		if ((rb.position.y < -1) || (float.IsNaN(rb.position.y)))
		{
			FindObjectOfType<GameManager>().EndGame();
		}

	}
}
