using UnityEngine;
using System.Collections;

public class NumberC : MonoBehaviour
{
	public float n;

	void Start ()
	{
		n = 1f + (1f / (2f + (1f / (2f + (1f / (2f + (1f / 2f)))))));
		print (n);
	}
}
