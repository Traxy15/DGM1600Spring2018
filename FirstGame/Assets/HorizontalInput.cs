using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewInput")]
public class HorizontalInput : InputBase {

	public override float FloatInput()
	{
		return input.GetAxis("Horizontal");
	}
}
