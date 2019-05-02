using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall : MonoBehaviour {
	
	private float healthMax;
	protected Slider healthBar;

	public static float health = 300;
		
	public void Start (){
			healthBar = transform.GetChild (0).GetComponent<Slider> ();
			healthMax = health;
	}

	public void DealDamage(float damage){
		health-= damage;
		healthBar.value = health / healthMax;
		if (health <= 0)
			GameManager.instance.GameOver();
			//Destroy (gameObject);
	}
	


}
