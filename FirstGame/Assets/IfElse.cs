using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {
public bool Key = false;
public int Health = 100;


	// Use this for initialization
	void Start () {
		if (Key){
			print("Abrakadabra");
		}

		else
		{
			print("YOU SHALL NOT PASS");
		}

		if(Health > 0){
			print("Play On");
		}
		else
		{
			print("You Dead");
		}

		
	}
	
}
