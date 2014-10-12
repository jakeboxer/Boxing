using UnityEngine;
using System.Collections;

public class BlockingIntervalOpponentController : IntervalOpponentController {
	public override void IntervalPassed () {
		if (leftControlState == ControlState.Idle) {
			leftControlState = ControlState.Block;
			rightControlState = ControlState.Idle;
		} else {
			leftControlState = ControlState.Idle;
			rightControlState = ControlState.Block;
		}
	}
}
