using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUp : MonoBehaviour {

public PowerUp MyPowerUp;


void OnMouseDown()
{
	//do work
	MyPowerUp.RunPowerUp();
}
}
