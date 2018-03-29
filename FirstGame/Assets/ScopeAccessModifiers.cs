using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAccessModifiers : MonoBehaviour {

	// Access Modifiers are when you set scripts to be publicly accessible within other scripts or if you want them
	//to stay accesible only within the type.
	//you have "public" which is fully accesible by enums and ints within your script
	//Internal which is only accesible within in the contained script assembly.
	//Private is accesible only within the type that is containing it.
	//and last we have protected which is type or subclass only accesible 
	//we've used a lot of public modifiers throught our work and I think a few protected in our silly calculators!

	public int dog = 5;
	private int cat = 10;
	public enum {dog, cat, dog_cat}
	protected enum {mousetrap, catNmouse}
	
}
