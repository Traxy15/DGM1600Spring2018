using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject {

	protected float aNum;
	protected float bNum;

	public string Calculate(String a, string b) 
{
	aNum = float.Parse(a);
	return FinishCalculation();
}

	public abstract string FinishCalculation();

}

	
