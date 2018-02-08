using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	// When you start the game, it is false
	bool gameHasEnded = false;

	// Restart delay
	public float restartDelay = 1f;

	public GameObject completeLevelUI;

	// Function for copleted level
	public void CompleteLevel ()
	{
		// Debug.Log ("LEVEL WON");			// Will show in console that Level won

		completeLevelUI.SetActive (true);
	}

	public void EndGame()
	{

		if (gameHasEnded == false) 
		{
			
			gameHasEnded = true;

			// Show this on console when game has ended
			Debug.Log ("GAME OVER");

			// Restart game by calling function/method
			// However we want a slight delay when restarting, so we call the "Invoke" function which
			// takes 2 parameters, name of function and an integer, in my case restart delay.
			Invoke("Restart", restartDelay);

			Debug.Log (score.int_score);
		}
	}

	void Restart ()
	{

		// SceneManager.LoadScene("Level01") OR
		// GetActiveScene gets name of scene and LoadScene loads name of scene.
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

		score.flt_position = 0;			// Reset player position score since failed level
		score.int_score = 0;			// Reset total score since failed level

		CoinScript.totalScore_int = 0;
	
	}

}
