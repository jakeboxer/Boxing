using UnityEngine;
using System.Collections;

public class PunchingIntervalOpponentController : IntervalOpponentController {
	public override void IntervalPassed () {
		if (leftControlState == ControlState.Idle) {
			leftControlState = ControlState.Punch;
			rightControlState = ControlState.Idle;
		} else {
			leftControlState = ControlState.Idle;
			rightControlState = ControlState.Punch;
		}
	}
}
