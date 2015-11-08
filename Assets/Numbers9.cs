using UnityEngine;
using System.Collections;
using System.Linq;

public class Numbers9 : MonoBehaviour
{
	void Start ()
	{
		//Test1 ();
		Test2 ();
	}

	void Test1 ()
	{
		float a1 = 2f;
		float d = 3f;
		int n = 10;
		float[] quary = SequenceDiff (a1, d, n);
		foreach (var item in quary) {
			print (item);
		}
		print ((n * (2 * a1 + (n - 1) * d)) / 2);		//等差数列の和の公式
		print (quary.Sum ());
	}

	void Test2 ()
	{
		float a1 = 100f;
		float d = -2f;
		int n = 10;
		float[] quary = SequenceDiff (a1, d, n);
		foreach (var item in quary) {
			print (item);
		}
		print ((n * (2 * a1 + (n - 1) * d)) / 2);		//等差数列の和の公式
		print (quary.Sum ());
	}
	
	//等差数列
	float[] SequenceDiff (float a, float d, int count)
	{
		float[] quary = Enumerable.Range (1, count).Select (n => a + (n - 1) * d).ToArray ();
		return quary;
	}
	
	//等比数列
	float[] SequenceRatio (float a, float r, int count)
	{
		float[] quary = Enumerable.Range (1, count).Select (n => a * Mathf.Pow (r, n)).ToArray ();
		return quary;
	}

}
