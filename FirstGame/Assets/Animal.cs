using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public bool Key = false;
	public bool Inventory = false;
	public bool Switch = false;
	public bool Electric =  false;

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
	}

	// Update is called once per frame
	void Update () {
		
	}
}
