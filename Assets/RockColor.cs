using UnityEngine;
using System.Collections;

public class RockColor : MonoBehaviour {

	public Material[] materials;

	// Use this for initialization
	void Start () {

		int colorPic = Random.Range(0, materials.Length);

		Renderer rend = GetComponent<Renderer> ();
		if (rend != null){
			rend.material = materials[colorPic];
			Debug.Log (materials);
			Debug.Log (colorPic);
		}





	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
