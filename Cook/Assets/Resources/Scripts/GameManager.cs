using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	#region Attributes

	private Image currAmmo;
    private Text scoreText, goldText;
	private Sprite[] AmmoSprites;
	public static GameManager instance = null;      //Singleton instance
    public static int Score = 0, gold = 0;
	private Player player;
	 

	#endregion

	#region Unity Event Functions

	void Awake()
    {
        Textİnitial();

        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        Screen.orientation = ScreenOrientation.Landscape;
        currAmmo = GameObject.Find("ammoImage").GetComponent<Image>();

        AmmoSprites = new Sprite[4];

        AmmoSprites[0] = Resources.Load<Sprite>("Sprites/Ammo/0");  //Empty icon
        AmmoSprites[1] = Resources.Load<Sprite>("Sprites/Ammo/1");
        AmmoSprites[2] = Resources.Load<Sprite>("Sprites/Ammo/2");
        AmmoSprites[3] = Resources.Load<Sprite>("Sprites/Ammo/3");
    }

    public void Textİnitial()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        scoreText.text = "Score : " + Score.ToString();
        goldText = GameObject.Find("Gold").GetComponent<Text>();
        goldText.text = "Gold : " + gold.ToString();
    }

    #endregion

    #region Methods
    public void showAmmo(){
		currAmmo.sprite =  AmmoSprites[Player.instance.Ammo];
	}

	public void reloadScore(){
		scoreText.text ="Score : " + Score.ToString();
	}
    public void reloadGold()
    {
        goldText.text = "Gold : " + gold.ToString();
    }

    public void ScoreGoldProgress(int s,int g) //first parameter get score for each enemy killed,second get gold for each enemy killed
    {
        Score += s;
        gold += g;
        reloadScore();
        reloadGold();
    }
	#endregion
}
