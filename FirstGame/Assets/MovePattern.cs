using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovePattern")]
public class MovePattern : ScriptableObject {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	public InputBase InputX;
	public InputBase InputY;
	public InputBase InputZ;

	public void Move(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
			{

				moveDirection.x = InputX.SetFloat();
				moveDirection.y = InputY.SetFloat();
				moveDirection.z = InputZ.SetFloat();
				moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpSpeed;
			}
	}
}
