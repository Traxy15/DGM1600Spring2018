using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {

	int numEnemies = 3;
	int pizzaSlice = 12;
	int servedSmoothies = 5;
	int powerUp = 50;
	int scoredGoal = 6;
	int yardsSwam = 100;
	int headShots = 3;
	int pushUps = 10;
	int carsCrashed = 4;
	int bridesMaids = 7;

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
		for (int g = 0; g < scoredGoal; g++)
			{
				Debug.Log("You scored " + g + " goals!!");
			}
		for (int y = 50; y < yardsSwam; y++)
			{
				Debug.Log("Just Keep Swimming. You've gone " + y + " yards!");
			}
		for (int h = 0; h < headShots; h++)
			{
				Debug.Log("Got Em! " + h);
			}
		for (int w = 0; w < pushUps; w++)
			{
				Debug.Log("one thousand and " + w + " !");
			}
		for (int c = 0; c < carsCrashed; c++)
			{
				Debug.Log("EEEEEEEEERRRRRK. You crashed " + c + " cars!");
			}
		for (int m = 1; m < bridesMaids; m++)
			{
				Debug.Log("Woah you have " + m + " brides maids!!??");
			}
	}

}
