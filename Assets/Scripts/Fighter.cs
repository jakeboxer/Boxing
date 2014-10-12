using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {
	public string displayName;
	public float maxHealth = 100f;
	public float health {
		get;
		private set;
	}
	public Fighter target;
	public GameObject takeDamageEffect;
	
	public Fist leftFist;
	public Fist rightFist;

	public bool isDead {
		get;
		private set;
	}

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

	public bool IsBlocking(Fist.FistSide fistSide) {
		return GetFist(fistSide).GetControlState() == FighterController.ControlState.Block;
	}

	public void Respawn () {
		isDead = false;
		health = maxHealth;
	}

	public void TakeDamage (float damage) {
		if (takeDamageEffect) {
			var positionOffset = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0f);
			Instantiate(takeDamageEffect, transform.position + positionOffset, transform.rotation);
		}

		health -= damage;

		if (health <= 0f) {
			Die();
		}
	}

	public Fist GetFist(Fist.FistSide fistSide) {
		if (fistSide == Fist.FistSide.Left) {
			return leftFist;
		} else {
			return rightFist;
		}
	}
}
