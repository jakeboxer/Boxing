using UnityEngine;
using System.Collections;

public class FighterController : MonoBehaviour {
	public enum ControlState { Idle, Block, Punch };
	
	public ControlState leftControlState = ControlState.Idle;
	public ControlState rightControlState = ControlState.Idle;
	
	private static readonly System.Array controlStateValues = System.Enum.GetValues(typeof(ControlState));

	public static ControlState RandomControlState () {
		return (ControlState) controlStateValues.GetValue(Random.Range(0, controlStateValues.Length));
	}
}
