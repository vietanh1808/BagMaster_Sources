using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat.SkillSystem
{
	public class MeleeThurst : MeleeBehaviour
	{
		[Header("Events")]
		public UnityEvent OnAttackStartEvent;

		public UnityEvent OnAttackEndEvent;

		public UnityEvent OnAttackBackEvent;

		protected override void MeleeAttack(Transform weapon, float distance, Vector3 direction)
		{
		}

		private void StartAttack()
		{
		}

		private void EndAttack()
		{
		}

		private void BackAttack()
		{
		}
	}
}
