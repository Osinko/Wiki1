using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class FourierCalc1 : MonoBehaviour
{
	int dt;
	float t, diff;

	void Start ()
	{
		int dt = 10;
		IEnumerable<float> FourierNum = FourierNumCalc (dt);

		float a0sum = 0;
		//TODO

		foreach (var item in FourierNum) {
			a0sum += item;
			print (item);
		}
		a0sum /= dt;
		print ("a0= " + a0sum);
	}

	IEnumerable<float>  FourierNumCalc (int dt)
	{
		t = 2 * Mathf.PI;
		diff = t / dt;

		float x = 0;
		for (int i = 0; i < dt; i++) {
			x = i * diff;
			yield return Fourier (x);
		}
	}

	//ここは本来ブラックボックス
	static float Fourier (float x)
	{
		float a0 = 0.78f;
		float a1 = 0.5f * Mathf.Cos (1 * x);
		float b1 = 0.2f * Mathf.Sin (1 * x);
		float a2 = 0.8f * Mathf.Cos (2 * x);
		float b2 = 0.3f * Mathf.Sin (2 * x);
		
		return (a0 + a1 + a2 + b1 + b2);
	}
}
