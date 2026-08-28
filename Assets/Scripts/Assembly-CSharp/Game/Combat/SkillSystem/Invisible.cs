using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class Invisible : BaseEffectImp
	{
		[Header("Invisible")]
		public float Duration;

		public override float EffDuration => 0f;

		public override void Initialize(EffectParams effectParams)
		{
		}

		public override void Execute(GameObject target)
		{
		}
	}
}
