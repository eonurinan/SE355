using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Ammo : MonoBehaviour {
	protected float speed;
	protected int damage;

    public void Move(float speed)
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

	void OnBecameInvisible(){
		Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		Debug.Log("I hit " + otherCollider.name);
		if (otherCollider.CompareTag("Enemy"))
		{
			Enemy enemy = otherCollider.GetComponent<Enemy>();
			enemy.DealDamage(damage);
			Destroy(gameObject);
		}

	}

}
