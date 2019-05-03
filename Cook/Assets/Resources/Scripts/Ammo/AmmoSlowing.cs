using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSlowing : Ammo {
    int slowingfactor = 2;
    void Start(){
	    speed = RemoteConfig.ammoSlowingSpeed;
	    damage = RemoteConfig.ammoSlowingDamage;
        
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
			enemy.GetSlow(slowingfactor);
            enemy.DealDamage(damage);
			Destroy (gameObject);
        }
    }
}
