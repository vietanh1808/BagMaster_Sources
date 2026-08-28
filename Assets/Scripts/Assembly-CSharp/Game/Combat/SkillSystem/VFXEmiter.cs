using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class VFXEmiter : ProjectileBehaviour
	{
		[SerializeField]
		private bool _isMelee;

		[SerializeField]
		private GameObject _hitVfxPrefab;

		[SerializeField]
		private Vector3 _hitVfxOffset;

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void PlayHitVfx(IEffectTarget hit)
		{
		}
	}
}
