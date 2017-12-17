using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekPlayer : MonoBehaviour {
	public Transform character;
	public float speed=0.1F;
	private Vector3 reachDistance;
	private float xAxisVar;
	private float zAxisVar;

	public void Awake()
	{
		character = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		xAxisVar = Random.Range(2f, 14f);
		zAxisVar = Random.Range(6f,-35f);

		reachDistance = new Vector3 (xAxisVar, 0.0f, zAxisVar);
	}

	void Update () {
		float steps = speed * Time.deltaTime;
		if (PlayerHealth.getPlayerHealthSystem () > 0) {
			transform.position = Vector3.MoveTowards (transform.position, (character.position - reachDistance), steps);
		}

	}

}
