using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTimeCalculations:MonoBehaviour {
	public static float time;
	public float waitTime;
	public float waitLimit;
	public float increaseValue;

	public void Start()
	{
		time = 2000;
	}

	public void increaseTime(float addValue)
	{
		time += addValue;
	}

	public void resetTimer()
	{
		time = 2000;
	}

	public float getTimer()
	{
		return time;
	}

	public void Update()
	{
		waitTime += Time.time;
		if (waitTime > waitLimit) {
			increaseTime (increaseValue);
			waitTime = 0.0f;
		}
			
	}

}
