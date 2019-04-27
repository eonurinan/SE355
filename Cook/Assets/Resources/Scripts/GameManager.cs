using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	#region Attributes

	private Image currAmmo;
	private Text scoreText;
	private Sprite[] AmmoSprites;
	public static GameManager instance = null;		//Singleton instance
	public static int Score = 0;
	private Player player;
	 

	#endregion

	#region Unity Event Functions

	void Awake()
	{
		scoreText = GameObject.Find("Score").GetComponent<Text>();
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);    

		DontDestroyOnLoad (gameObject);

		Screen.orientation = ScreenOrientation.Landscape;
		currAmmo = GameObject.Find ("ammoImage").GetComponent<Image>();

		AmmoSprites = new Sprite[4];

		AmmoSprites[0] = Resources.Load <Sprite> ("Sprites/Ammo/0");	//Empty icon
		AmmoSprites[1] = Resources.Load <Sprite> ("Sprites/Ammo/1");
		AmmoSprites[2] = Resources.Load <Sprite> ("Sprites/Ammo/2");
		AmmoSprites[3] = Resources.Load <Sprite> ("Sprites/Ammo/3");
	}

	#endregion

	#region Methods

	void Killed(Enemy enemy){
		 //Increase score according to the enemy type
	}

	public void showAmmo(){
		currAmmo.sprite =  AmmoSprites[Player.instance.Ammo];
	}

	public void reloadScore(){
		scoreText.text =  Score.ToString();
	}

	public void addScore(int i){
		Score += i;
		
		reloadScore();
	}

	#endregion
}
