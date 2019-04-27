using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienBird : Enemy
{
    void Start()
    {
        speed = 1.5f;
        health = 50;
        damage = 10;

		healthBar = transform.GetChild (0).GetChild (0).GetComponent<Slider> ();
		healthMax = health;
    }
    void Update()
    {
        Move();
    }
   
}
