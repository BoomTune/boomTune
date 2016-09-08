using UnityEngine;
using System.Collections;

public class Forward : MonoBehaviour {
	public float speed = 1f;
	Vector3 startPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * speed * Time.deltaTime);

		if (GameObject.Find("Cube").transform.position.z >= 100000f) {
			
			transform.position = startPos;
		}
	}
}
