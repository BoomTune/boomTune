using UnityEngine;
using System.Collections;

public class IMovementController : MonoBehaviour
{
	
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	Vector3 startPos;
	Vector3 Lane1;
	Vector3 Lane2;

	public void startingPosition (float lane1x, float lane1y, float lane1z, float lane2x, float lane2y, float lane2z) {
		startPos = transform.position;
		startTime = Time.time;
		Lane1 = (lane1x, lane1y, lane1z);
		Lane2 = (lane2x, lane2y, lane2z);
	}


	public void MoveLane (string value) {


		if (value == ("right")) {
				transform.position = Vector3.Lerp(startingPosition.Lane1, Lane2, 0f);
		}

		if (value == ("left")) {
			transform.position = Vector3.Lerp(Lane1.position, Lane2.position, 0f);
		}

	}
}


//	public void Loop () {
//		
//		if (GameObject.Find("Cube").transform.position.z >= 50f) {
//			transform.position = startPos;
//		}
//	}


