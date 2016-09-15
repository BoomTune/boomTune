using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed;
	Vector3 startPos;

	// Use this for initialization
	void Start () {

		startPos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (0f, 0f, Speed * Time.deltaTime);


		if (GameObject.Find ("Player").transform.position.z >= 1000f) {
			transform.position = startPos;
		}
			
	}

}
