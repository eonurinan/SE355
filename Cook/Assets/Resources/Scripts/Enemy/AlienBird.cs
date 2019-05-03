using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienBird : Enemy
{
    void Start()
    {
        speed = RemoteConfig.alienBirdSpeed;
        health = RemoteConfig.alienBirdHealth;
        damage = RemoteConfig.alienBirdDamage;

		healthBar = transform.GetChild (0).GetChild (0).GetComponent<Slider> ();
		healthMax = health;
    }
    void Update()
    {
        Move();
    }
   
}
