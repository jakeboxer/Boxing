using UnityEngine;
using System.Collections;

public class FighterController : MonoBehaviour {
	public enum ControlState { Idle, Block, Punch };
	
	public ControlState leftControlState = ControlState.Idle;
	public ControlState rightControlState = ControlState.Idle;
}
