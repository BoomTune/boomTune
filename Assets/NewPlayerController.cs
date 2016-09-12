using UnityEngine;
using System.Collections;

public class NewPlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0f, 0f, 10f * Time.deltaTime);
	
	}
}
