using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cauldron : MonoBehaviour {

	#region Attributes

	private Text txt;
	public int ID;				// Determines the order in lanes
								// 1:Top,3:Bottom
	public int ammoType;		// Determines the Ammo type
	                            // 1 = Standard Ammo
	                            // 2 = Slowing Ammo
	                            // 3 = Lane Swiper Ammo

	public int fillSpeed;     	//Production speed of the couldron

    public int ammoStored = 0;	//Stored ammo count

    private float percentage = 0;		//When percentage reaches 100, new ammo will be added.

	#endregion

	#region Unity Event Functions

	void Start(){
		txt = transform.GetChild(1).GetComponent<Text>();
		RefreshText ();
		fillSpeed = (4-ammoType)*10;
	}

	void Update(){
		percentage += Time.deltaTime*fillSpeed;
		if (percentage >= 100) {
			ammoStored++;
			percentage = 0;
			RefreshText ();
		}
	}

	#endregion

	#region Methods

	void RefreshText (){
		txt.text = ammoStored.ToString();
	}
	public void GiveAmmo(){	
		Player p = Player.instance;
		if (p.currentLane == 3 - ID) {
			if (p.Ammo == 0 && ammoStored > 0) {
				p.Ammo = ammoType;
				ammoStored--;
				RefreshText ();
				GameObject.Find ("GameManager").GetComponent<GameManager>().showAmmo();
			}
		}
	}

	#endregion
	}
