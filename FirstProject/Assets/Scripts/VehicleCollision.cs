using UnityEngine;

public class VehicleCollision : MonoBehaviour {

	// A reference to our player (vehicle movement)
	public VehicleMovement vehiclemovement;


	// This function runs when we hit another object.
	// we get information about the collision and call it "collisionInfo"/
	void OnCollisionEnter (Collision collisionInfo)
	{
		// Checks to see if the player collided with object tagged "obstacle"
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			// If player hits obstacle then it will not move
			vehiclemovement.enabled = false;

			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
