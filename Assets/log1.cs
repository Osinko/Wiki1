using UnityEngine;
using System.Collections;

public class log1 : MonoBehaviour
{
		void Start ()
		{
				print (Mathf.Log10 (8) / Mathf.Log10 (13));
				print (Mathf.Log (8, 13));
				print (Mathf.Pow (13, 0.8107145f));
		}
}
