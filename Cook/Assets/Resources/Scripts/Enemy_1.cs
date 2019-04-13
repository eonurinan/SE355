using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : Enemy
{
    void Start()
    {
        Collider.radius = 0.19f;
        transform.localScale = new Vector3(1.2f, 1.2f, 1);
       
    }

    /*public override void MovemenetPattern()
    {
        Body.velocity = new Vector2(1 * Direction, Body.velocity.y);
    }*/
}