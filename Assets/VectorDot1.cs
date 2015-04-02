using UnityEngine;
using System.Collections;

public class VectorDot1 : MonoBehaviour
{
		Vector3 vec1, vec2;
		float angle;
		void Start ()
		{
				vec1 = new Vector3 (3, 0, 0);
				vec2 = new Vector3 (5, 0, 0);
				vec1 = Quaternion.AngleAxis (30, Vector3.forward) * vec1;
				angle = Vector3.Dot (vec1, vec2) / (vec1.magnitude * vec2.magnitude);

				print ("a・b/(|a||b|) = cosθ = " + angle);
				print ("これは斜辺の長さ１。隣辺の長さcosθの傾き（角度）の計算できる事を意味するのでsinθで縦の長さも出る");
		}
}
