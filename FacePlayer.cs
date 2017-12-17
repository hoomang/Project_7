using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {
    public Transform player;
    public float distance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(player.position, transform.position);

        if (distance < 10)
            transform.LookAt(player);
	}
}
