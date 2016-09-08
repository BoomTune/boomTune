using UnityEngine;
using System.Collections;

public class PlayerControllerScript: MonoBehaviour 
{
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;

	public int laneNumber = 0;
	public int lanesCount = 4;
	bool didChangeLastFrame = false;
	public float laneDistance = 2;
	public float firstLaneXPos = 0;
	public float deadZone = 0.1f;
	public float sideSpeed = 5;

	void Start()
	{
		
		CharacterController controller = GetComponent<CharacterController>();
	}


	void Update() {
		//Access the objects Character Controller


		CharacterController controller = GetComponent<CharacterController>();

		float input = Input.GetAxis("Horizontal");
		//Make sure the object is grounded before doing the math for lane changes
		if (controller.isGrounded)
		if(Mathf.Abs(input) > deadZone) {
			if(!didChangeLastFrame) {
				didChangeLastFrame = true; //Prevent overshooting lanes
				laneNumber += Mathf.RoundToInt(Mathf.Sign(input));
				if(laneNumber < 0) laneNumber = 0;
				else if(laneNumber >= lanesCount) laneNumber = lanesCount - 1;
			}
		}
		else 
		{
			didChangeLastFrame = false;

			moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;

		}
		Vector3 pos = transform.position;
		pos.x = Mathf.Lerp(pos.x, firstLaneXPos + laneDistance * laneNumber, Time.deltaTime * sideSpeed);
		transform.position = pos;

		moveDirection.y -= gravity * Time.deltaTime;        
		controller.Move (moveDirection * Time.deltaTime);
	}
}