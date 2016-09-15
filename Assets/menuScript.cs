using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

	public Button startText;
	// Use this for initialization
	void Start () {
		startText = startText.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartLevel () {
		Application.LoadLevel ("Level1");
	}
}
