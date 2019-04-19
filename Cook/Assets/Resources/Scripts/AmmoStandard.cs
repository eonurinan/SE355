using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoStandard : Ammo {
	void Start(){
		speed = 10;
		damage = 5;
	}

	void Update(){
		transform.Translate (Vector2.right * Time.deltaTime * speed);

	}
}
