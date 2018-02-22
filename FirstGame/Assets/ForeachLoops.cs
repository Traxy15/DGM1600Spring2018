using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoops : MonoBehaviour {


	void Start () {

		string[] strings = new string[10];

		strings[0] = "Hello";
		strings[1] = "How are You";
		strings[2] = "I'm enjoying my day off";
		strings[3] = "I think everyone deserves more days off";
		strings[4] = "especially if they go to work and school full time";
		strings[5] = "This shit is hard";
		strings[6] = "I mean I'm tough but I'm burning out here!";
		strings[7] = "I only have 3 more lines and I'm burning out";
		strings[8] = "I am a burning flame and I'm at the end of my wick";
		strings[9] = "Star wars is keeping me sane... ish";

		foreach(string item in strings)
		{
			print (item);
		}
		

	}
		

}
