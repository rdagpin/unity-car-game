using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {


	// Function that will load next scene
	// Will play after level complete animation on timeline.
	public void LoadNextLevel ()
	{

		// In File, Build Settings, you can see loaded scenes with their index to the right, by default the first scene is 0
		// Getting the current scene's build index and adding 1 to play next level.
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);

		// Reset score before next level
		ResetScore ();

	}
		
	void ResetScore()
	{
		CoinScript.totalScore_int = 0;		// Reset score
	}

}
