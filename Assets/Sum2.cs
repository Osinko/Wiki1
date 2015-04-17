using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Sum2 : MonoBehaviour
{

	void Start ()
	{
		Func<float,float> f = Gravity;
	}

	float Integral (float upper, Func<float,float> f, float delta)
	{

	}

	float Gravity (float dt)
	{
		return 9.8f * dt;
	}


	
}
