using UnityEngine;
using System.Collections;

public class CollisionController : MonoBehaviour {

	Vector3 startPos;

	void Start () {

		startPos = transform.position;

	}

	void OnTriggerEnter(Collider other) {
		
		Application.LoadLevel(Application.loadedLevel);

	}
}
	

