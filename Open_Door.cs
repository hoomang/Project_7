using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public float angle;
	void Update () {
		if (ScoreSystem.getScore() >= 5)
		{
		angle = transform.eulerAngles.z;
		if (angle > 250)
		transform.Rotate(Vector3.forward * Time.deltaTime * -5);
		}		
	}
}
