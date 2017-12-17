using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : MonoBehaviour {
	public Transform player;
	public float distance;
	public Vector3 transPosition;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transPosition = transform.position;
		 distance = Vector3.Distance (player.position, transform.position);
		 Vector3 temp = new Vector3 (transform.position.x, player.position.y, transform.position.z);
		 temp.Normalize ();
		transform.Translate (temp  * Time.deltaTime);

			 
	}
		
}
