using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player1;
	// Vector3 stores 3 floats, can store x, y, z
	public Vector3 offset;

	// Update is called once per frame
	void Update () 
	{
		
		transform.position = player1.position + offset;
			
	}
}
