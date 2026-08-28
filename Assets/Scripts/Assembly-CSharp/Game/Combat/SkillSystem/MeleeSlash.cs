using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat.SkillSystem
{
	public class MeleeSlash : MeleeBehaviour
	{
		[Header("Events")]
		public UnityEvent OnSlashStartEvent;

		public UnityEvent OnSlashEndEvent;

		public UnityEvent OnBackStartEvent;

		protected override void MeleeAttack(Transform weapon, float distance, Vector3 direction)
		{
		}

		private void StartSlash()
		{
		}

		private void StopSlash()
		{
		}

		private void StartBack()
		{
		}
	}
}
