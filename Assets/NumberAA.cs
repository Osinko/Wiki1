using UnityEngine;
using System.Collections;

public class NumberAA : MonoBehaviour
{

		void Start ()
		{
				float a, b, left, right;
				bool success = true;
		
				for (int i = 0; i < 50; i++) {
						a = 0;
						b = 0;
						GenerateRandom (ref a, ref b);
						left = (a + b) / 2f;
						right = Mathf.Sqrt ((a * b));
						print (string.Format ("a={0} : b={1} : {2} > {3}", a, b, left, right));
						if (!(left >= right)) {
								print ("成立しない！");
								success = false;
						}
				}
				if (success) {
						print ("成立する");
				}
		}
	
		static void GenerateRandom (ref float a, ref float b)
		{
				while (a == 0 || b == 0) {
						a = Random.Range (0f, 100f);
						b = Random.Range (0f, 100f);
				}
		}
}
