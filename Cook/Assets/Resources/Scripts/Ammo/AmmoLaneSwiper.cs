﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoLaneSwiper : Ammo {
	void Start(){
		speed = 15;
		damage = 1000;
	}

	void Update(){
		Move(speed);
    }

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Debug.Log("I hit " + otherCollider.name);
		if (otherCollider.CompareTag("Enemy"))
		{
			Enemy enemy = otherCollider.GetComponent<Enemy>();
			enemy.DealDamage(damage);
			
		}

	}

}
