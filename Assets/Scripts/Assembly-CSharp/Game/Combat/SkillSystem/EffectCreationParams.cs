using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public struct EffectCreationParams
	{
		public IEffectCaster Caster;

		public IEffectGear Gear;

		public object EffectSource;

		public Stat.GetValueCustomDelegate StatModifierFilter;

		public EffectData EffectData;

		public List<IEffect> Effects;

		public Vector3 Origin;

		public float Angle;

		public bool NonCrit;
	}
}
