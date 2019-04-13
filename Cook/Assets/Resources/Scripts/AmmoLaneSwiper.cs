using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoLaneSwiper : Ammo {
	void Start(){
		speed = 3;
		damage = 1000;
	}

	void Update(){
		transform.Translate (Vector2.right * Time.deltaTime * speed);

	}
}
