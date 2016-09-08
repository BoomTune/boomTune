using UnityEngine;
using System.Collections;
//using IMovementController;

public class Cube : MonoBehaviour {

	public CubeController controller;
	public Transform Lane1;
	public Transform Lane2;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	Vector3 startPos;
	public CubeController CubeController;
	// Use this for initialization

	void Start () {

		CubeController.startPosition (Lane1.position.x, Lane1.position.y, Lane1.position.z, Lane2.position.x, Lane2.position.y, Lane2.position.z);
//		startPos = transform.position;
//		startTime = Time.time;
//		journeyLength = Vector3.Distance(Lane1.position, Lane2.position);
	}

	// Update is called once per frame


	void Update () {

		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;

		if (Input.GetKey("right")) {
			CubeController.moveSideToSide("right"); 
//			transform.position = Vector3.Lerp(Lane1.position, Lane2.position, fracJourney);
		}

		if (Input.GetKey("left")) {
//			IMovementController.MoveLane("right"); 
			transform.position = Vector3.Lerp(Lane2.position, Lane1.position, fracJourney);
		}

		if (GameObject.Find("Cube").transform.position.z >= 50f) {
			transform.position = startPos;
		}


		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,10f*Time.deltaTime);
	}
		
}
	



