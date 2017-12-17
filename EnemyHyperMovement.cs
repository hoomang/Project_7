using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHyperMovement {
	public float waittime;
	public float waitLimit;
	private static float increaseSpeed;
	void Awake()
	{
		increaseSpeed = .2f;
	}

	public void increase(float speed)
	{
		increaseSpeed += speed;
	}

	public float getIncreasedSpeed()
	{
		return increaseSpeed;
	}

	public void Update()
	{
		waittime += Time.time;
		if (waittime > waitLimit) {
			increase (.2f);
			waittime = 0.0f;
		}
			
	}
}
