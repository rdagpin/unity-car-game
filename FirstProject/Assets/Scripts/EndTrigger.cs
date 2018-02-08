using UnityEngine;

public class EndTrigger : MonoBehaviour {


	public GameManager gameManager;

	void OnTriggerEnter ()
	{

		// Will show the CompleteLevel function in  GameManger script.
		// Note that anything else other than the player that will pass the end trigger will also set this off.
		gameManager.CompleteLevel();

		// Call this function before showing scores to save scores
		FindObjectOfType<GetActiveScene> ().GetScene ();

		// Show me score of each scene/level
		Debug.Log ("Level 1 : " + GetActiveScene.levelOne);
		Debug.Log ("Level 2 : " + GetActiveScene.levelTwo);
		Debug.Log ("Level 3 : " + GetActiveScene.levelThree);
		Debug.Log ("Level 4 : " + GetActiveScene.levelFour);
	}
}
