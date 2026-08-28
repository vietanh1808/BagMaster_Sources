using UnityEngine;

namespace Game.Combat
{
	public struct EAoeParams
	{
		public float EffectScale;

		public EAoeShape Shape;

		public float[] AoeProperties;

		public Vector3 Origin;

		public float Degrees;

		public IEffect LinkedEffect;
	}
}
