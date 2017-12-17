using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlaySpawnners : MonoBehaviour {
	public GameObject enemy;
	public Transform spawnlocation;
	public float waitTime;
	public float upTime;
	public int numberofenemies;
	public static int counter;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		waitTime += Time.time;

		if (counter < numberofenemies) {
			if (waitTime > upTime) {
				Instantiate (enemy, spawnlocation.position, spawnlocation.rotation);
				counter++;
				waitTime = 0.0f;
			}

		}
		//Debug.Log (counter);
			
	}
}
