using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_2 : Enemy
{
    private void Start()
    {
        Collider.radius = 0.19f;
        transform.localScale = new Vector3(1.2f, 1.2f, 1);
    }
}
