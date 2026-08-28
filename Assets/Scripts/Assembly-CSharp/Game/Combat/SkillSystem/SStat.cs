using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class SStat : BaseEffectImp
	{
		[Header("Stat")]
		public int StatId;

		public ModificationType Type;

		public float Value;

		public override void Initialize(EffectParams effectParams)
		{
		}

		public override void Execute(GameObject target)
		{
		}
	}
}
