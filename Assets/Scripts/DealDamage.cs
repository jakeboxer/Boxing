using UnityEngine;
using System.Collections;

public class DealDamage : MonoBehaviour {
	public Character target;
	public float damage = 10f;

	public void Fire () {
		if (target == null) { return; }

		target.TakeDamage(damage);
		Debug.Log("dealing damage");
	}
}
