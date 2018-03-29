using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	int numEnemies = 3;
	int pizzaSlice = 12;
	int servedSmoothies = 5;
	int powerUp = 50;

	void Start () {
		for (int i = 0; i < numEnemies; i++)
		{
			Debug.Log("Creating enemy number: " + i);
		}

		for (int p = 1; p < pizzaSlice; p++)
			{
				Debug.Log("Eating pizza slice number: " + p);
			}

		for (int s = 1; s < servedSmoothies; s++)
			{
				Debug.Log("Order number " + s + " is up!");
			}
		
		for (int u = 25; u < powerUp; u++)
			{
				Debug.Log("Losing " + u + " health!");
			}
	}
	

}
