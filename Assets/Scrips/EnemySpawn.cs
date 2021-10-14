using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
	public GameObject Object;
	float timebtwspawn;
	public float startTimeBtwSpawn;
//	public float spawnDelay;

	void Update()
	{
		if (timebtwspawn <= 0)
		{
			Instantiate(Object, transform.position, Quaternion.identity);
			
		}
		else
		{
			timebtwspawn -= Time.deltaTime;
		}
		
	}
}