using UnityEngine;
using System.Collections;

using System.Linq;
using System.Collections.Generic;
using System.IO;

public class Numbers3 : MonoBehaviour
{
	void Start ()
	{
		IEnumerable<Seq> number = Seq.GeneratorNum (100);
		Show (number.Take (5));
		//コンソールには5要素表示
		//資料：
		//http://ufcpp.net/study/csharp/sp3_stdqueryo.html

		string folder = Application.dataPath;    	//unityの実行ファイルがあるフォルダ（Assetsフォルダ内に生成される）
		IEnumerable<string> strList = number.Select (n => n.ToString ()).ToArray ();
		SaveText (folder, @"\test.txt", strList);
	}

	//表示用補助関数
	static void Show<T> (IEnumerable<T> num)
	{
		foreach (var item in num) {
			print (item);
		}
	}

	//結果をテキストファイルとしてセーブする補助関数
	public void SaveText (string fileFolder, string filename, IEnumerable<string> dataStr)
	{
		using (StreamWriter w = new StreamWriter(fileFolder+filename)) {
			foreach (var item in dataStr) {
				w.WriteLine (item);
			}
		}
	}

	//数列用クラス
	public class Seq
	{
		//分母
		public int denominator;

		//分子
		public int numerator;

		//実数
		public float realNumber;

		public override string ToString ()
		{
			return string.Format ("({0}/{1})^{1} ... {2}", numerator, denominator, realNumber);
		}

		//この数列クラス用の固有の式
		public static IEnumerable<Seq> GeneratorNum (int count)
		{
			for (int n = 1; n <= count; n++) {
				yield return new Seq{ denominator = n , numerator = n+1 , realNumber = Mathf.Pow(((n+1f)/n),n) };
			}
		}
	}
}
