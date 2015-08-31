using UnityEngine;
using System.Collections;
using System;

public class Logic2 : MonoBehaviour
{
	int mask, p, q, r;

	void Start ()
	{
		//2進数でint値を設定

		p = Convert.ToInt32 ("11110000", 2);
		q = Convert.ToInt32 ("11001100", 2);
		r = Convert.ToInt32 ("10101010", 2);

		//ビットマスク
		mask = Convert.ToInt32 ("11111111", 2);
		
		int PconditonalQ = (~p | q) & mask;	// p⇒q
		int PconjunctionPconditonalQ = (p & PconditonalQ) & mask;	// p^(p⇒q)
		int PconjunctionPconditonalQconjunctionR = (~PconjunctionPconditonalQ | r) & mask;	// (p^(p⇒q))⇒r
		int negationPconjunctionPconditonalQconjunctionR = ~PconjunctionPconditonalQconjunctionR & mask;	// ￢((p^(p⇒q))⇒r)

		int total = (~(~(p & (~p | q)) | r)) & mask;	//￢((p^(p⇒q))⇒r)

		print (Convert.ToString (PconditonalQ, 2).PadLeft (8, '0'));
		print (Convert.ToString (PconjunctionPconditonalQ, 2).PadLeft (8, '0'));
		print (Convert.ToString (PconjunctionPconditonalQconjunctionR, 2).PadLeft (8, '0'));
		print (Convert.ToString (negationPconjunctionPconditonalQconjunctionR, 2).PadLeft (8, '0'));
		print (Convert.ToString (total, 2).PadLeft (8, '0'));
	}
}
