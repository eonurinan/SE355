using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSlowing : Ammo {
	void Start(){
		speed = 8;
		damage = 1;
	}

	void Update(){
		transform.Translate (Vector2.right * Time.deltaTime * speed);

	}
}
