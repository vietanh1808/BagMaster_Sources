using System;
using UnityEngine;

namespace Game.Combat
{
	public class EAoe : IEffect
	{
		protected delegate bool HitPosition(Vector3 position);

		protected EAoeParams _params;

		protected HitPosition _hitCheck;

		protected float _aoeSizeMultiplier;

		protected Action _onExecute;

		public float Intensity { get; set; }

		public EAoe(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EAoeParams param)
		{
		}

		protected void GetAoeSizeMultiplier(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		protected virtual void InitializeCollider()
		{
		}

		public void Execute(IEffectTarget target)
		{
		}

		protected virtual bool VerifyTarget(IEffectTarget target, out Unit targetUnit)
		{
			targetUnit = null;
			return false;
		}
	}
}
