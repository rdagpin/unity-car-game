using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetActiveScene : MonoBehaviour {

	public static int levelOne = 0, levelTwo = 0, levelThree = 0, levelFour = 0;

	public void GetScene () 
	{
		Scene sceneOne = SceneManager.GetSceneByBuildIndex (1);
		Scene sceneTwo = SceneManager.GetSceneByBuildIndex (2);
		Scene sceneThree = SceneManager.GetSceneByBuildIndex (3);
		Scene sceneFour = SceneManager.GetSceneByBuildIndex (4);

		if (sceneOne.name == "Level01") 
		{
			levelOne = score.int_score;					// Level 1 score
		}

		if (sceneTwo.name == "Level02") 
		{
			levelTwo = score.int_score;					// Level 2 score
		}	

		if (sceneThree.name == "Level03") 
		{
			levelThree = score.int_score;				// Level 3 score
		}	

		if (sceneFour.name == "Level04") 
		{
			levelFour = score.int_score;				// Level 3 score
		}	
	}

}
