using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Logic1 : MonoBehaviour
{

	bool[] p, q, r;
	IEnumerable<bool> PconditionalQ;

	void Start ()
	{
		r = new bool[] {true,false,true,false,true,false,true,false,};
		q = new bool[] {true,true,false,false,true,true,false,false,};
		p = new bool[] {true,true,true,true,false,false,false,false,};

		PconditionalQ = Conditional (p, q);
		string PconditionalQstr = "";
		foreach (var item in PconditionalQ) {
			PconditionalQstr += string.Format ("{0} ", item.ToString ());
		}
		print (PconditionalQstr);

	}

	public IEnumerable<bool> Conditional (bool[] p, bool[] q)
	{
		if (p.Length == q.Length) {
			for (int i = 0; i < p.Length; i++) {
				yield return !p [i] || q [i];
			}
		}
	}

	public IEnumerable<bool> Conjunction (bool[] p, bool[] q)
	{
		if (p.Length == q.Length) {
			for (int i = 0; i < p.Length; i++) {
				yield return p [i] && q [i];
			}
		}
	}

	
}
