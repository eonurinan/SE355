using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour
{
    private float healthMax;
    protected Slider healthBar;

    public float health;

    public void Start()
    {
        health = RemoteConfig.wallHealth;
        healthBar = transform.GetChild(0).GetComponent<Slider>();
        healthMax = health;
    }

    public void DealDamage(float damage)
    {
        health -= damage;
        healthBar.value = health / healthMax;
        if (health <= 0)
            Destroy(gameObject);
    }


/* 	public 
	void OnTriggerStay2D(Collider2D col){
		if (col.CompareTag("Enemy")){
			Health--;
			Debug.Log (Health);
			healthBar.value = (float) Health / HealthMax;
			if (Health <= 0)
				Destroy (gameObject);
		}
	}
	*/
}