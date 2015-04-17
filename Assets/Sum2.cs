using UnityEngine;
using System.Collections;
using System;

public class Sum2 : MonoBehaviour
{
		void Start ()
		{
				print (Integral (4f, 0.01f, Gravity));
				print (Integral (0.5f * Mathf.PI, 0.01f, Sin));
		}

		float Integral (float t, float dt, Func<float,float> f)
		{
				float parts = t / dt;
				float sum = 0;

				for (int n = 1; n <= parts; n++) {
						sum += f (dt * n) * dt;
				}
				return sum;
		}

		float Gravity (float t)
		{
				return 9.8f * t;
		}

		float Sin (float t)
		{
				return Mathf.Sin (t);
		}
}
