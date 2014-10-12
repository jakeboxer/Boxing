using UnityEngine;
using System.Collections;

public class RandomIntervalOpponentController : IntervalOpponentController {
	public override void IntervalPassed () {
		leftControlState = FighterController.RandomControlState();
		rightControlState = FighterController.RandomControlState();
	}
}
