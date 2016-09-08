using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	public Transform Lane1;
	public Transform Lane2;
	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
//	Vector3 startPos;
	// Use this for initialization
	void Start () {
//		startPos = transform.position;
		startTime = Time.time;
		journeyLength = Vector3.Distance(Lane1.position, Lane2.position);
	}

	// Update is called once per frame
	void Update () {

		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;

		if (Input.GetKey("right")) {
			transform.position = Vector3.Lerp(Lane1.position, Lane2.position, fracJourney);
		}

		if (Input.GetKey("left")) {
			transform.position = Vector3.Lerp(Lane2.position, Lane1.position, fracJourney);
		}


//		if (GameObject.Find("Cube").transform.position.z >= 50f) {
//			transform.position = startPos;
//		}
//		else if (GameObject.Find("Cube").transform.position.y <= -50f) {
//			transform.position = startPos;
//		}
//		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,10f*Time.deltaTime);
	}

}
