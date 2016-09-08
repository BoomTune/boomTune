using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {
	public Transform Lane1;
	public Transform Lane2;
	public Transform Lane3;
	public Transform Lane4;
	private float startTime;
	private float journeyLength;
//	
	// Use this for initialization
	void Start () {
//		startPos = transform.position;
		startTime = Time.time;
		journeyLength = Vector3.Distance(Lane1.position, Lane2.position);

	}

	// Update is called once per frame
	void Update () {


		float fracJourney = 1.0f;
//			distCovered / journeyLength;
	
		if (Input.GetKeyDown ("right")) {
			if (gameObject.transform.position == Lane1.transform.position) {
				transform.position = Vector3.Lerp (Lane1.transform.position, Lane2.transform.position, fracJourney);
			}
			else if (gameObject.transform.position == Lane2.transform.position) {
				transform.position = Vector3.Lerp (Lane2.transform.position, Lane3.transform.position, fracJourney);
			}
			else if (gameObject.transform.position == Lane3.transform.position) {
				transform.position = Vector3.Lerp (Lane3.transform.position, Lane4.transform.position, fracJourney);
			}
		}


		if (Input.GetKeyDown ("left")) {
			if (gameObject.transform.position == Lane4.transform.position) {
					transform.position = Vector3.Lerp (Lane4.transform.position, Lane3.transform.position, fracJourney);
				}

				else if (gameObject.transform.position == Lane3.transform.position) {
					transform.position = Vector3.Lerp (Lane3.transform.position, Lane2.transform.position, fracJourney);
				}
				else if (gameObject.transform.position == Lane2.transform.position) {
					transform.position = Vector3.Lerp (Lane2.transform.position, Lane1.transform.position, fracJourney);
				}
		
		}
			

}
	//This function resets the position
		
//		else if (GameObject.Find("Cube").transform.position.y <= -50f) {
//			transform.position = startPos;
//		}
//		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime,0f,10f*Time.deltaTime);
			
		}
