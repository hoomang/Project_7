using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guiz : MonoBehaviour {
	public float gizmoSize = .75f;
	public Color gizmoColor = Color.yellow;

	void OnDrawGizmo()
	{
		Gizmos.color = gizmoColor;
		Gizmos.DrawSphere (transform.position, gizmoSize);
	}
}
