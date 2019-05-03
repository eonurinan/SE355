using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoStandard : Ammo {
	void Start(){
		speed = RemoteConfig.ammoStandardSpeed;
		damage = RemoteConfig.ammoStandardDamage;
	}

	void Update(){
		Move(speed);
    }
}
