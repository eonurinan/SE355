using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy<T> where T : Enemy
{
    public GameObject GameObject;
    public T ScriptComponent;   

    public Enemy(string name )
    {
        GameObject = new GameObject(name);
        ScriptComponent = GameObject.AddComponent<T>();
    }
}
public abstract class Enemy : MonoBehaviour
{
    public Rigidbody2D Body;
    public SpriteRenderer Sprite;
    public CircleCollider2D Collider;

    public int Speed;
    public int Direction;
    public int Health;
    public int Damage;
    //sprotected abstract void MovementPattern();
    void Awake()
    {
        //Adding common components
        Body = gameObject.AddComponent<Rigidbody2D>();
        Sprite = gameObject.AddComponent<SpriteRenderer>();
        Collider = gameObject.AddComponent<CircleCollider2D>();

        //Seting common sprite

        Sprite.sprite = Resources.Load<Sprite>("Apple");
        Body.collisionDetectionMode = CollisionDetectionMode2D.Continuous;

        gameObject.tag = "Enemy";
        gameObject.layer = LayerMask.NameToLayer("Apple");
    }
   
    public  void Initialize(int speed,int direction,int health,int damage,Vector3 position)
    {
        Speed = speed;
        Direction = direction;
        transform.position = position;
        Health = health;
        Damage = damage;

    }
}




