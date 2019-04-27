using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienOctopus : Enemy
{
    void Start()
    {
        speed = 0.5f;
        health = 100;
        damage = 10;

		healthBar = transform.GetChild (0).GetChild (0).GetComponent<Slider> ();
		healthMax = health;

    }

    void Update()
    {
		Move();
    }
}
