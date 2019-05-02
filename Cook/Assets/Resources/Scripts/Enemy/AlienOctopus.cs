using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlienOctopus : Enemy
{
    void Start()
    {
        speed = RemoteConfig.alienOctopusSpeed;
        health = RemoteConfig.alienOctopusHealth;
        damage = RemoteConfig.alienOctopusDamage;

        healthBar = transform.GetChild(0).GetChild(0).GetComponent<Slider>();
        healthMax = health;
    }

    void Update()
    {
        Move();
    }
}