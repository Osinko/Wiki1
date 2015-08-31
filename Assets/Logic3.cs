using UnityEngine;
using System.Collections;
using System;

public class Logic3 : MonoBehaviour
{

	void Start ()
	{
		//2進数でint値を設定
		
		int t = Convert.ToInt32 ("1100", 2);
		int w = Convert.ToInt32 ("1010", 2);
		
		//ビットマスク
		int mask = Convert.ToInt32 ("11111111", 2);

		print (Convert.ToString ((t | w) & mask, 2).PadLeft (4, '0'));
		print (Convert.ToString ((~(~t) | w) & mask, 2).PadLeft (4, '0'));
	}
	
}
