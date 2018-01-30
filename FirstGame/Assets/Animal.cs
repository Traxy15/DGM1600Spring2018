using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public string Name;

public int FoodCount;


	void OnMouseDown()
	{
		if (1 + 2 == 3)
		{
		print(3);	
		}

		if (FoodCount > 10)
		{
			print("The pet has food.");
		}

		if (FoodCount < 5){
			print("your pet is low on food.");
		}

		if (FoodCount!= 0){
			print("your pet is dead.");
		}

		if (Name == "Dog"){
			print("Woof");
		}

		if (Name == "pet"){
			print("Yipee");
		}
	
		if (5 * 2 == 10){
			print("no it's not");
		}
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
