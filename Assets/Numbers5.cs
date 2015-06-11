using UnityEngine;
using System.Collections;

public class Numbers5 : MonoBehaviour
{
	void Start ()
	{
		float x0 = 3f;
		float c = 15f;

		float x1 = 0;

		for (int i = 0; i < 7; i++) {
			x1 = (1f / 4f) * ((3f * x0) + (c / Mathf.Pow (x0, 3f)));
			x0 = x1;
		}
		print (x1);
	}
}
