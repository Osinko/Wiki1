using UnityEngine;
using System.Collections;

public class Fourier1 : MonoBehaviour
{
		public enum Function
		{
				Linear,
				Exponential,
				Parabola,
				Sine,
				Fourier,
		}

		public Function function;
	
		delegate float FunctionDelegate (float x);
	
		static FunctionDelegate[] functionDelegates = {
		Linear,
		Exponential,
		Parabola,
		Sine,
		Fourier,
		};

		[Range(10,1000)]
		public int
				resolution = 10;
		[Range(0.01f,2)]
		public float
				particleSize = 0.1f;

		int currentResolution;
		float currentParticleSize;
		ParticleSystem pe;

		ParticleSystem.Particle[] point;
		void Start ()
		{
				pe = gameObject.AddComponent<ParticleSystem> ();
				pe.startSpeed = 0;
				pe.startLifetime = int.MaxValue;

				CreatePoint ();
		}

		void CreatePoint ()
		{
				if (resolution < 10 || resolution > 1000) {
						Debug.LogWarning ("解像度が大きすぎるか小さすぎます", this);
						resolution = 10;
				}
				currentResolution = resolution;
				currentParticleSize = particleSize;

				pe.Emit (resolution);
				point = new ParticleSystem.Particle[resolution];
				pe.GetParticles (point);

				float increment = 1f / (resolution - 1);
				for (int i = 0; i < resolution; i++) {
						float x = i * increment;
						point [i].position = new Vector3 (x, 0, 0);
						point [i].color = new Color (x, 0, 0);
						point [i].size = particleSize;
						point [i].lifetime = int.MaxValue;
				}
				pe.SetParticles (point, resolution);
		}

		void Update ()
		{
				if (currentResolution != resolution || currentParticleSize != particleSize || point == null) {
						CreatePoint ();
				}
				//実行中にリアルタイムにレゾリューションを変更した場合、即座に反映させる
				//配列が空でも生成する
		
				//デリゲートセレクタ
				FunctionDelegate f = functionDelegates [(int)function];
		
				for (int i = 0; i < resolution; i++) {
						Vector3 p = point [i].position;
						p.y = f (p.x);
						point [i].position = p;
			
						Color c = point [i].color;
						c.g = c.r;
						point [i].color = c;
			
			
				}
				particleSystem.SetParticles (point, point.Length);
		}

		//リニア
		static float Linear (float x)
		{
				return x;
		}
	
		//f(x) = x^2
		//右上がりのグラフ
		static float Exponential (float x)
		{
				return x * x;
		}
	
		//f(x) = (2x-1)^2
		//放物線
		static float Parabola (float x)
		{
				x = 2f * x - 1f;
				return x * x;
		}
	
		//f(x) = (sin(2πx)+1)/2
		//サインカーブ
		static float Sine (float x)
		{
				return 0.5f + 0.5f * Mathf.Sin (2 * Mathf.PI * x + Time.timeSinceLevelLoad);
		}

		static float Fourier (float x)
		{
				float a0 = 0.5f;
				float a1 = 0.5f * Mathf.Cos (2 * Mathf.PI * 1 * x);
				float b1 = 0.2f * Mathf.Sin (2 * Mathf.PI * 1 * x);
				float a2 = 0.8f * Mathf.Cos (2 * Mathf.PI * 2 * x);
				float b2 = 0.3f * Mathf.Sin (2 * Mathf.PI * 2 * x);

				return (a0 + a1 + a2 + b1 + b2);
		}
}
