using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisioManager : MonoBehaviour {
	public GameObject sparks;
	void Awake(){
		if (!sparks) {
			print ("Missing sparks particle prefab!");
		}
	}


	void OnCollisionStay(Collision other){
		if (other.transform) {
			ContactPoint contact= other.contacts [0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal) * Quaternion.Euler(-90,0,0);
			Vector3 pos = contact.point;
			Instantiate (sparks, pos, rot);
		}
	}


}
