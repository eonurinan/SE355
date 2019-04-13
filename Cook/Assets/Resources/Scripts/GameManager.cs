using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	
	#region Attributes

	public static GameManager instance = null;		//Singleton instance
	public static int Score = 0;

	#endregion

	#region Unity Event Functions

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);    

		DontDestroyOnLoad (gameObject);

		Screen.orientation = ScreenOrientation.Landscape;
	}

	#endregion

	#region Methods

	void Killed(Enemy enemy){
		 //Increase score according to the enemy type
	}

	#endregion
}
