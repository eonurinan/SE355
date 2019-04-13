using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    void Awake()
    {
        Enemy<Enemy_1> Enemy_A = new Enemy<Enemy_1>("Enemy_A");
        Enemy_A.ScriptComponent.Initialize(
            speed: 4,
            direction: Random.Range(0, 2) * 2 - 1,
            position: new Vector3(1, 1, 1),
            health: 10, damage: 5
            
            );
        Enemy<Enemy_2> Enemy_B = new Enemy<Enemy_2>("Enemy_B");
        Enemy_B.ScriptComponent.Initialize(
            speed: 4,
            direction: Random.Range(0, 2) * 2 - 1,
            position: new Vector3(3, 3, 3),
            health: 10, damage: 5

            );
    }
    
}
