using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public bool Key = false;
	public bool Inventory = false;
	public bool 

	void OnMouseDown()
	{
		if(Key == true){
			print ("Abrakadabra");
		}

		if(Inventory == true){
			print ("You've collected the gas can");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
