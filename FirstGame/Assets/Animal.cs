using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public bool Key = false;
	public bool Inventory = false;
	public bool Switch = false;
	public bool Electric =  false;
	public bool Health = 100;
	public bool Password = "OU812";

	void OnMouseDown()
	{
		if(Key == true){
			print ("Abrakadabra");
		}

		if(Inventory == true){
			print ("You've collected the gas can");
		}

		if(Switch == true){
			print("Radio is on");
		}

		if(Electric == true){
			print("Lights are on");
		}

		if(Health > 0){
			print("Can Play")
		}
		else
		{
			print("You're Dead.")
		}

		if(Password == "OU812"){
			print("That's Correct!");
		}
		else
		{
			print("Nice Try Sucker!");
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
