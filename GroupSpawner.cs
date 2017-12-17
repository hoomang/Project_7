using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupSpawner : MonoBehaviour {
	public float waitTime;
	public float waitLimit;
	public GameObject group;


	
	// Update is called once per frame
	void Update () {
		spawnTimeCalculations cal = new spawnTimeCalculations ();
		waitLimit = cal.getTimer ();

		waitTime += Time.time;

		if (waitTime > waitLimit) {
			
			if (group != null) {
				Instantiate (group, transform.position, transform.rotation);
			}
			waitTime = 0.0f;
		}
			
	}
}
