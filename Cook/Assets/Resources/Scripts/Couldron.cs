using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Couldron : MonoBehaviour {

	#region Attributes

	public int ID;					// Determines the Ammo type
	// 1 = Standard Ammo
	// 2 = Slowing Ammo
	// 3 = Lane Swiper Ammo

	private int _fillSpeed;			//Production speed of the couldron
	public int fillSpeed{
		get{return _fillSpeed;} 
		set{_fillSpeed = value;} 
	}

	private int _ammoStored=0;		//Stored ammo count
	public int ammoStored{
		get{return _ammoStored;}
		set{_ammoStored=value;}
	}

	private float percentage = 0;		//When percentage reaches 100, new ammo will be added.

	#endregion

	#region Unity Event Functions

	void Update(){
		percentage += Time.deltaTime*fillSpeed;
		if (percentage >= 100) {
			ammoStored++;
			percentage = 0;
		}
	}

	#endregion

	#region Methods

	void Cook(){

		/*switch(ammoType){
		case 1: Player.Ammo = Prefab1;
		case 2: Player.Ammo = Prefab2;
		case 3: Player.Ammo = Prefab3
	}
	*/
	
	#endregion
	}
}