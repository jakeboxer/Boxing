using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public enum ControlState { Idle, Block, Punch };

	public ControlState leftControlState = ControlState.Idle;
	public ControlState rightControlState = ControlState.Idle;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey("'")) {
			rightControlState = ControlState.Punch;
		} else if (Input.GetKey("/")) {
			rightControlState = ControlState.Block;
		} else {
			rightControlState = ControlState.Idle;
		}

		if (Input.GetKey("a")) {
			leftControlState = ControlState.Punch;
		} else if (Input.GetKey("z")) {
			leftControlState = ControlState.Block;
		} else {
			leftControlState = ControlState.Idle;
		}
	}
}
