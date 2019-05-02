using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

abstract public class Enemy : MonoBehaviour
{
	protected int damage,health,healthMax;
    protected float speed,defSpeed;
	protected Slider healthBar;
	protected GameObject Wall;

	public void Start (){
		healthBar = transform.GetChild (0).GetChild (0).GetComponent<Slider> ();
		healthMax = health;
		defSpeed = speed;

	}

    public void DealDamage(int dealt)
    {
		health -= dealt;
		healthBar.value = (float) health/healthMax;
			
        if (health <= 0)
        {
			GameManager.instance.addScore(5);
            Destroy(gameObject);
        }
    }
    public void GetSlow(int slowfactor)
    {
        speed /= slowfactor;
    }
	public void Move()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.CompareTag("Wall"))
		{
			Wall = otherCollider.gameObject;
			InvokeRepeating("reduceWallHealth",0.01f,1f);
			speed = 0;

		}
	}

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (otherCollider.CompareTag("Wall"))
		{
			speed = defSpeed;
		}
	}

	protected void reduceWallHealth(){
		Wall.GetComponent<Wall>().DealDamage(damage);
		
	}

}
