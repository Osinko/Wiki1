using UnityEngine;
using System.Collections;

using System;

public class Numbers7 : MonoBehaviour
{
	void Start ()
	{
		print (upper (5f));
		//print (lim (3, f));
	}

	//lim[x→a]f(x)=b をεδ論法を利用してコード化したもの
	//最初のドミノとしてこの関数はepsilonを要求している
	float lim (float a, Func<float,float> f)
	{
		//float epsilon = Random.Range (float.MinValue, float.MaxValue);
		float epsilon = 0.5f;
		float m = 2f;






		return 0f;
	}

	//n>m　のような値、nを返す
	float upper (float m)
	{
		float n = UnityEngine.Random.Range (m, float.MaxValue);
		return n;
	}

	//関数f(x)=x^2
	float f (float x)
	{
		return x * x;
	}
	
}
