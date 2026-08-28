using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class MeleeAttacker : MonoBehaviour, IShooter
	{
		private MeleeController _meleeController;

		public ShooterOptions Options { get; set; }

		public void Initialize(string behaviourId)
		{
		}

		public void Fire(IReadOnlyCollection<IEffectTarget> targets)
		{
		}

		private void DoHit(IEffectTarget target)
		{
		}

		private float GetAoeMultiplierBonus()
		{
			return 0f;
		}

		public void Cancel()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
