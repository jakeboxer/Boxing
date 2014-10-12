using UnityEngine;
using System.Collections;

public class OpponentController : FighterController {
	public float speed = 1f;

	private ControlState lastLeftControlState;
	private ControlState lastRightControlState;
	private float timeSinceLastControlStateChange = 0f;
	
	// Update is called once per frame
	void Update () {
		timeSinceLastControlStateChange += Time.deltaTime;

		if (timeSinceLastControlStateChange >= speed) {
			timeSinceLastControlStateChange = 0f;
			SwapPunchingHands();
		}
	}

	private void SwapPunchingHands () {
		if (leftControlState == ControlState.Idle) {
			leftControlState = ControlState.Punch;
			rightControlState = ControlState.Idle;
		} else {
			leftControlState = ControlState.Idle;
			rightControlState = ControlState.Punch;
		}
	}
}
