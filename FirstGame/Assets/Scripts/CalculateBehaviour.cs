using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateBehaviour : MonoBehaviour {

public InputField Input1;
public InputField Input2;
public Text SolutionText;

public Calculation Calculation;

public void RunCalculation()
{
	SolutionText.text = Calculation.Calculate(Input1.text, Input2.text);
	
}
}
