using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	#region Attributes

	public static Player instance = null;		//Singleton instance

	public int currentLane;

	public int Ammo;
		//This is the ID of ammo that player is holding.
		//ID's are:
		// 1 = Standard Ammo
		// 2 = Slowing Ammo
		// 3 = Lane Swiper Ammo

	private GameObject[] AmmoPrefabs;

	#endregion

	#region Unity Event Functions

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
	}

	void Start(){
		Move (1);
		Ammo = 1;
		GameObject.Find ("GameManager").GetComponent<GameManager>().showAmmo();

		AmmoPrefabs = new GameObject[3]; 

		AmmoPrefabs [0] = Resources.Load<GameObject> ("Prefabs/Bread_Standard");
		AmmoPrefabs [1] = Resources.Load<GameObject> ("Prefabs/Chicken_Slowing");
		AmmoPrefabs [2] = Resources.Load<GameObject> ("Prefabs/Spicy_Swiper");

	}

	#endregion

	#region Methods

	public void Move(int Lane){		//BODY WILL BE CONVERTED TO COROUTINE LATER for interpolation.
									//Final version will be a Cororoutine in a Function, for using at button OnClick() event.

									//Lanes differ within 0,1 and 2 by according buttons.

									// Width and Height are Dimensions in Landscape mode.
									//Landscape, because we fixed the screen orientation as landscape in Game Manager.

									//Parameters will change later because offsets will be added when GUI design is finalized.
									//Screen.height / 6 is our minimum moving unit. There are 3 lanes, we divide them by 2 to stay in the middle of them.

		Vector3 screen = new Vector3 (Screen.width / 4, Screen.height / 6 + (Lane) * Screen.height / 3,  10);
		transform.position = UnityEngine.Camera.main.ScreenToWorldPoint(screen);	

		currentLane = Lane;
	}

	public void Shoot(int desiredLane){
		if (desiredLane == currentLane) {
			if (Ammo == 0)
				Debug.Log ("No ammo");
			else {
				GetComponent<Animator>().SetTrigger("ToThrow");
				Instantiate (AmmoPrefabs [Ammo - 1], transform.position, transform.rotation);
				Ammo = 0;
				GameObject.Find ("GameManager").GetComponent<GameManager>().showAmmo();

			}
		} 			
	}

	#endregion
}
