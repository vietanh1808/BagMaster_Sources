using Game.AssetManager;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class VFXEmiterBullet : ProjectileBehaviour
	{
		[SerializeField]
		private bool _autoCreateTrailVfx;

		[SerializeField]
		private Vector3 _trailVfxOffset;

		[SerializeField]
		private string _wallHitVfxPath;

		[SerializeField]
		private bool _autoAssignHitVfxOnHitEvent;

		private PrefabAddressable _wallHitVfxLoader;

		[Header("Options")]
		public float DelayHitVfx;

		private VFXService _appearVfxService;

		private VFXService _hitVfxService;

		private VFXService _hitAttachVfxService;

		private VFXService _hitWallVfxService;

		private VFXService _trailVfxService;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void PlayHitVfx(IEffectTarget hit)
		{
		}

		public void PlayHitVfx()
		{
		}

		private void PlayHitAttachVfx(IEffectTarget hit)
		{
		}

		public void PlayTrailVfx()
		{
		}

		public void StopTrailVfx()
		{
		}

		public Vector3 GetImpactPosition()
		{
			return default;
		}
	}
}
