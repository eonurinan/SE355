using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoStandard : Ammo {
	void Start(){
		speed = 10;
		damage = 50;
	}

	void Update(){
		Move(speed);
    }
}
