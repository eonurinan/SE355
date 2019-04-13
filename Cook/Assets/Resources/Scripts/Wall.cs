using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
	private int _Health = 100;
	public int Health {
		get{ return _Health; }
		set{ _Health = value; }
	}

	void onCollisionEnter(Collision col){
		if (col.gameObject.CompareTag("Enemy")){
			Health--;
		}
	}
}
