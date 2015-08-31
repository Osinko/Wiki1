using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Numbers1 : MonoBehaviour
{
	IEnumerable	num;

	void Start ()
	{
		//num = GenaratorNumDiff (1, 2, 5);
		num = GenaratorNumRatio (3, 2, 5);

		foreach (var item in num) {
			print (item);
		}
	}

	IEnumerable <float> GenaratorNumDiff (float a, float d, int count)
	{
		for (int i = 1; i <= count; i++) {
			yield return SequenceDiff (a, d, i);
		}
	}

	static float SequenceDiff (float a, float d, int n)
	{
		return a + (n - 1) * d;
	}

	IEnumerable <float> GenaratorNumRatio (float a, float r, int count)
	{
		for (int i = 1; i <= count; i++) {
			yield return SequenceRatio (a, r, i);
		}
	}

	static float SequenceRatio (float a, float r, int n)
	{
		return a * Mathf.Pow (r, (float)n);
	}
}
