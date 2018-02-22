using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	//Arrays are a way of storing same type data together. An array is a collection of data.

	int[] myIntArray = new int[10];

	void void Start()
	{
		myIntArray[0] = 230;
		myIntArray[1] = 45;
		myIntArray[2] = 01;
		myIntArray[3] = 498;
		myIntArray[4] = 1000;
		myIntArray[5] = 29;
		myIntArray[6] = 542;
		myIntArray[7] = 10;
		myIntArray[8] = 8492;
		myIntArray[9] = 2838;
		myIntArray[10]= 46;
	}
	
	int[] myIntArray = {230, 45, 01, 498, 1000, 29, 542, 10, 8492, 2838, 46};
