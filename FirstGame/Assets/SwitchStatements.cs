using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour {

//Switch statements are used when you would use an if/else statement, but need to reference multiple variables.

public int height = 5;

void Greet(){

	switch(height)
	{
		case 5:
			print("Wow You're mighty tall");
			break;

		case 4:
			print("You're getting taller");
			break;

		case 3:
			print("You're at the average!");
			break;
		
		case 2:
			print("Haha nice try shorty");
			break;
		case 1:
			print("Wow I've never seen a midget in real life");
			break;

		default:
			print("Not even an ant over here");
			break;
	}
}

public int Health = 5;

	void GoodBye()
	{
		switch(Health)
		{
			case 5:
				print("Looking in good health sir");
				break;
			case 4:
				print("Just a bit dinged up sir. Nothing a little buffer can't fix");
				break;
			case 3:
				print("Scraping by the skin of your teeth I see.");
				break;
			case 2:
				print("My God you look WRECKED!");
				break;
			case 1:
				print("Lucky is what I'd call it");
				break;
			default:
				print("You died");
				break;
		}
	}