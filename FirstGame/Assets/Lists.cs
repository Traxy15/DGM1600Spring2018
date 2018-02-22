using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lists : MonoBehaviour{
// a list is used in place of an array when more functionality is required. 
	void void Start()
	{
		List<BadGuy> badguy = new List<BadGuy>();

		badguys.Add ( new BadGuy ("Michael", 50));
		badguys.Add ( new BadGuy ("OctoMom", 25));
		badguys.Add ( new BadGuy ("Tiger Mom", 75));
		badguys.Add ( new BadGuy ("Traxy", 100));
		badguys.Add ( new BadGuy ("Your Mom", 1000));
		badguys.Add ( new BadGuy ("C3P0", 5));
		badguys.Add ( new BadGuy ("The Doctor", 190));
		badguys.Add ( new BadGuy ("Casio", 48));


		badguys.Sort ();

		foreach(BadGuy guy in badguys)
		{
			print (guy.name + " " + guy.power);
		}
		badguys.Clear ();
	}



}
