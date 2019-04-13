using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	#region Attributes

	public static Player instance = null;		//Singleton instance

	private int _currentLane;
	public int currentLane{
		get {return _currentLane;}
		set { _currentLane = value; }
	}

	private int _Ammo;
	public int Ammo{				//This is the ID of ammo that player is holding.
		get {return _Ammo;}			//ID's are:
		set { _Ammo = value; }		// 1 = Standard Ammo
									// 2 = Slowing Ammo
									// 3 = Lane Swiper Ammo
	}

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
			//Instantiate ammo prefab, corresponding to the ammo ID.
		} 			
	}

	public void TakeAmmo(Couldron couldron){					//Will execute when clicked to a couldron.
		if (Ammo == null && couldron.ammoStored > 0) {
			Ammo = couldron.ID;
			couldron.ammoStored--;
		}
	}

	#endregion
}
