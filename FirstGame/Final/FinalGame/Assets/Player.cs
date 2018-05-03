using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	[Tooltip("In ms^-1")][SerializeField] float speed = 20f;
	[Tooltip("In m")][SerializeField] float xRange = 5f;
	[Tooltip("In m")][SerializeField] float yRange = 3f;

	[SerializeField] float positionPitchFactor = -5f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		ProcessTranslation();
		ProcessRotation();
	}
 
 private void ProcessRotation()
 {
	 float pitch = transform.localPosition.y * positionPitchFactor;
	 float yaw = 0f;
	 float roll = 0f;

	 transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
 }
	private void ProcessTranslation()
	{	
		float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		float yThrow = CrossPlatformInputManager.GetAxis("Vertical");

		float xOffset = xThrow * speed * Time.deltaTime;
		float yOffset = yThrow * speed * Time.deltaTime;

		float rawXPos = transform.localPosition.x + xOffset;
		float clampedXPos = Mathf.Clamp(rawXPos, -xRange, xRange);
		
		
		float rawYPos = transform.localPosition.y + yOffset;
		float clampedYPos = Mathf.Clamp(rawYPos, -yRange, yRange);

		transform.localPosition = new Vector3(clampedXPos, clampedYPos,transform.localPosition.z);
	
		
	}
}
