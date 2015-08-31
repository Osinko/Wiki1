using UnityEngine;
using System.Collections;

public class numberA : MonoBehaviour
{
		float a1 = 2f;
		float d = 1.5f;
		int nn = 7;
		float particleSize = 0.3f;
	
		ParticleSystem pe;
		ParticleSystem.Particle[] point;

		void Start ()
		{
				pe = gameObject.AddComponent<ParticleSystem> ();
				pe.startSpeed = 0;
				pe.startLifetime = float.MaxValue;	//寿命が有限なのでいつか消えます（無限寿命を指定する方法は仕様上無い？）
		
				CreatePoint ();
		}

		void CreatePoint ()
		{
				pe.Emit (nn);
				point = new ParticleSystem.Particle[nn];
				pe.GetParticles (point);

				for (int n = 0; n < nn; n++) {
						//パーティクルの配列は0を含むので等差数列の計算時はnに+1している
						point [n].position = new Vector3 (ArithmeticProgression (a1, n + 1, d), 0, 0);
						point [n].color = Color.white;
						point [n].size = particleSize;
				}
				pe.SetParticles (point, nn);
		}

		float ArithmeticProgression (float a1, int n, float d)
		{
				float an = a1 + (n - 1) * d;
				return an;
		}
}
