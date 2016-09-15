using UnityEngine;
using System.Collections;

public class HorseAudioEffect : MonoBehaviour {

	int detail = 1;
	float amplitude = 0.1f;
	float startScale;
	// Use this for initialization
	void Start () {
		startScale = transform.localScale.y;
	}

	// Update is called once per frame
	void Update () {
		float[] info = new float[detail];
		AudioListener.GetOutputData (info, 0);
		float packageData = 0.0f;
		for(int x = 0;x < info.Length; x++)
		{
			packageData += System.Math.Abs (info [x]);
		}

		//        System.Console.WriteLine (packageData);
		Vector3 temp = transform.localScale; 
		temp.y = (startScale + packageData * amplitude);
		temp.x = (startScale + packageData * amplitude);
		temp.z = (startScale + packageData * amplitude);
		transform.localScale = temp;


	}
}
