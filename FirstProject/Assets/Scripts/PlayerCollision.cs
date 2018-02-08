using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle") 
		{
			// If player hits obstacle then it will not move
			movement.enabled = false;
		}
	}
}
