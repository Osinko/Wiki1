using UnityEngine;
using System.Collections;

public class FourierCalc1 : MonoBehaviour
{
		int deltaT;
		float t;

		void Start ()
		{
				deltaT = 10;
				t = 2 * Mathf.PI;
				for (int i = 0; i < deltaT; i++) {
			
				}
	
		}

		static float Fourier (float x)
		{
				float a0 = 0.5f;
				float a1 = 0.5f * Mathf.Cos (2 * Mathf.PI * 1 * x);
				float b1 = 0.2f * Mathf.Sin (2 * Mathf.PI * 1 * x);
				float a2 = 0.8f * Mathf.Cos (2 * Mathf.PI * 2 * x);
				float b2 = 0.3f * Mathf.Sin (2 * Mathf.PI * 2 * x);
		
				return (a0 + a1 + a2 + b1 + b2);
		}
}
