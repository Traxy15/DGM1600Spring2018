using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {apartment, mirror, blanket_0, lock_0, apartment_mirror, sheets_1, lock_1, freedom};
	private States myState;

	void Start () {
		myState = States.apartment;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
			if (myState == States.apartment) {
			state_cell ();
			} else if (myState == States.blanket_0) {
			state_blanket_0 ();
			} else if (myState == States.mirror) {
				state_mirror ();
			} else if (myState == States.lock_0) {
				state_lock_0();
			}
		
	}

	void state_cell () {
		text.text = "You are in a small apartment, and you want to escape. There " +
					"are some blankets on the couch, a mirror on the wall, and the " +
					"door is locked with a code.\n\n" +
					"Press B to view Blankets, M to view Mirror, L to view Lock";

		if (Input.GetKeyDown(KeyCode.B)){
			myState = States.blanket_0;
		}

		if (Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		}

		if (Input.GetKeyDown(KeyCode.L)){
			myState = States.lock_0;
		}
	}

		void state_blanket_0 () {
		text.text = "The blankets are folded nice. Looks like someone put a lot of " +
					"time and effort into making the place look comfortable for you. " +
					"isn't that ironic.\n\n" +
					"Press R to Return to investigating the apartment.";
						
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.apartment;
		}
	}

			void state_mirror () {
			text.text = "The mirror looks oddly dirty.There's a giant smudge in the corner. " +
						"You try cleaning it but nothing seems to do the trick. You realize you are seeing " +
						"a crack in the mirror. You tilt the mirror and find a loose shard of glass.\n\n" +
						"Press G to pick up the glass. Press R to Return to the apartment.";
						
				if (Input.GetKeyDown(KeyCode.R)){
				myState = States.apartment;
				} 
				 if (Input.GetKeyDown(KeyCode.G)){
					myState = States.apartment_mirror;
				}
}
			void state_lock_0 () {
			text.text = "Looks like a keypad lock. You have no idea what the code could be. " +
						"See if there are items around to help you crack the code. " +
						"Hopefully this place isn't too cleaned up.\n\n" +
						"Press R to Return to the apartment.";
						
				if (Input.GetKeyDown(KeyCode.R)){
				myState = States.apartment;
		}

		
			}
}