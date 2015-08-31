using UnityEngine;
using System.Collections;

public class Numbers6 : MonoBehaviour
{
	void Start ()
	{
		float t0 = 15f;
		float c = 700f;
		
		float t1 = 0;
		
		for (int i = 0; i < 5000; i++) {
			t0 = (1f / 2f) * (t0 + (c / (4.9f * t0)));
			t1 = t0;
		}
		print (t0);
	}
}
