using UnityEngine;
using System.Collections;

public class DealDamage : MonoBehaviour {
	public float damage = 10f;

	private Fighter fighter;

	void Start () {
		fighter = GetComponent<Fighter>();
	}

	public void Fire () {
		if (fighter.target == null) { return; }

		fighter.target.TakeDamage(damage);
	}
}
