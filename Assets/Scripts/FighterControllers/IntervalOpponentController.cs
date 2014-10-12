using UnityEngine;
using System.Collections;

public abstract class IntervalOpponentController : FighterController {
	public float speed = 1f;
	
	private float timeSinceLastControlStateChange = 0f;
	
	// Update is called once per frame
	void Update () {
		timeSinceLastControlStateChange += Time.deltaTime;
		
		if (timeSinceLastControlStateChange >= speed) {
			timeSinceLastControlStateChange = 0f;
			IntervalPassed();
		}
	}

	public abstract void IntervalPassed ();
}
