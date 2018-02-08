using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {

	public Transform player;					// Reference to player
	public static float flt_position = 0;		// Will hold the position of player
	public static int int_score;				// Will hold total score

	// This is the variable linked to the score on the screen
	public Text scoreText;						// Get type Text (found in inspection), reference to label

	//public static Scene levelOne = SceneManager.GetActiveScene();

	// Update is called once per frame
	void Update () 
	{

		flt_position = player.position.z;		// This gets position of player
		// Debug.Log (flt_position); this was used to see position of player in console

		// Now add position of player with coins
		int_score = (int)flt_position + CoinScript.totalScore_int;

		// Debug.Log (int_score); used to test if total score was being shown

		scoreText.text = int_score.ToString ("0");



	}
		
}
