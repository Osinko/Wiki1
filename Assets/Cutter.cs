using UnityEngine;
using System.Collections;

public class Cutter : MonoBehaviour
{
	void Start ()
	{
		DedekindCut cut;
		cut = new DedekindCut ();
		cut.B = 2.5f;

		print (string.Format ("DedekindCut(  {0}  ,  {1}  )", cut.A, cut.B));
	}

	class DedekindCut
	{
		double a;
		double b;

		public double A {
			get {
				return a;
			}
		}

		public double B {
			set {
				//一つ隣の点、計算機イプシロンが引算された値
				//unityでの最小値　資料：http://d.hatena.ne.jp/nakamura001/20150117/1421501942
				a = value - 1.192093E-07;
				b = value;
			}
			get {
				return b;
			}
		}
	}
}
