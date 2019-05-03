using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienBaloon : Enemy
{

    void Start()
    {
	    speed = RemoteConfig.alienBalloonSpeed;
		health = RemoteConfig.alienBalloonHealth;
		damage = RemoteConfig.alienBalloonDamage;

		healthBar = transform.GetChild (0).GetChild (0).GetComponent<Slider> ();
		healthMax = health;
    }

    void Update()
    {
		Move();
    }
}