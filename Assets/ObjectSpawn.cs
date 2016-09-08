using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour
{
	private Transform _target;
	public Transform[] prefab;
	public int numMin;
	public int numMax;
	public int num;
	public float xmin;
	public float xmax;
	public float ymin;
	public float ymax;
	public float zmin;
	public float zmax;
	private float rndNr;
	private float tmprnd;
	private int i = 0;

	void Start()
	{
		_target = GameObject.Find("Player");
		// random number of prefabs
		num =Random.Range(numMin, numMax);
	}

	void Update()
	{
		// find the Player
		GameObject _target = GameObject.FindGameObjectWithTag("Player");
		// distance between the player and the Prefab GameObject
		float dist = Vector3.Distance(_target.transform.position, this.transform.position);

		if (dist > 20f)
		{
			i = 0;
			num =Random.Range(numMin, numMax);
		}
		// distance between the Player and the GameObject
		if (dist < 10f)
		{
			while (i < num)
			{
				rndNr=Mathf.Ceil(Random.value*prefab.Length);
				rndNr-=1;
				if(tmprnd==rndNr)
				{
					rndNr=Mathf.Ceil(Random.value*prefab.Length);
					rndNr-=1;
				}
				Object.Instantiate(prefab[(int)rndNr], new Vector3(transform.position.x+Random.Range(xmin, xmax), transform.position.y, transform.position.z+Random.Range(ymin, ymax)), transform.rotation);
				tmprnd = rndNr;
				i++;
			}
		}
	}
}

