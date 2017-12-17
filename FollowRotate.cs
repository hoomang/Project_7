using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotate : MonoBehaviour {

	private GameObject target;
	private Vector3 targetPoint;
	private Quaternion targetRotation;

	void Start () 
	{
		target = GameObject.FindWithTag("Player");
	}

	void Update()
	{
		if (PlayerHealth.getPlayerHealthSystem() > 0.0f) {
			targetPoint = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z) - transform.position;
			targetRotation = Quaternion.LookRotation (-targetPoint - new Vector3(-.25f, 0, 0), ( Vector3.up));
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
		}
			

			
	}
}
