using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour {

	public Transform player;				// Get position of player

	public static int Coins = 100;					// Value of coins
	public Text playerPosition;				// Position of player as a Text value
	public static int totalScore_int;		// Total score as int, this is a global variable

	public static Text totalText;			// Total score as a Text value

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Makes coin rotate
		transform.Rotate (0, 0, 90 * Time.deltaTime);
		
	}

	// Function that triggers when player hits coin
	public void OnTriggerEnter (Collider other)
	{

		// make sure the name of the vehice in each level is "Vehicle_3".
		if (other.name == "Vehicle_3") 
		{
			Destroy (gameObject);										// Make coin disappear
			FindObjectOfType<AudioMangaer> ().Play ("CoinPickup");		// Play sound when coin is collected

			// Gets position of player and converts to String
			playerPosition.text = player.position.z.ToString ("0");


			// Now add position of player with coins
			// For some reason this score shows at the start of each level, so had to reset this before each level
			totalScore_int += (int)score.flt_position + Coins;

			score.int_score += (int)score.flt_position + Coins;


			// Debug.Log (totalScore_int);
			// Debug.Log (score.int_score);

		}
	}
}
