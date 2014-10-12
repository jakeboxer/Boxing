using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	public float maxHealth = 100f;
	public float health {
		get;
		private set;
	}
	public bool isDead {
		get;
		private set;
	}
	public GameObject takeDamageEffect;

	void Awake () {
		health = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Die () {
		isDead = true;
		health = 0f;
	}

	public void Respawn () {
		isDead = false;
		health = maxHealth;
	}

	public void TakeDamage (float damage) {
		if (takeDamageEffect) {
			Instantiate(takeDamageEffect, transform.position, transform.rotation);
		}

		health -= damage;

		if (health <= 0f) {
			Die();
		}
	}
}
