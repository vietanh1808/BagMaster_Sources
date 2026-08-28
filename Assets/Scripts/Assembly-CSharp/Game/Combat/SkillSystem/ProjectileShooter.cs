using System;
using System.Collections.Generic;
using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ProjectileShooter : MonoBehaviour, IShooter
	{
		private SimpleObjectPool<ProjectileController> _bulletPool;

		public ShooterOptions Options { get; set; }

		public void Initialize(string behaviourId)
		{
		}

		public void Fire(IReadOnlyCollection<IEffectTarget> targets)
		{
		}

		public void Cancel()
		{
		}

		private void SpreadProjectile(SkillData skillData, IEffectTarget target, EffectController effectController, float delay, int numberPrj, float arcBetweenPrj, float arcBetweenPrjRnd, float duration)
		{
		}

		private void SpreadBulletToTargets(SkillData skillData, IReadOnlyCollection<IEffectTarget> targets, EffectController effectController, float delay, int numberPrj, float duration)
		{
		}

		private float GetAoeMultiplyBonus()
		{
			return 0f;
		}

		private void CreateProjectileObjCompletely(SkillData skillData, EffectController effectController, IEffectTarget target, float aoeMultiplierBonus, float angle, float delay, float incommingDamage, Vector2 endPositionOffset, float duration)
		{
		}

		private ProjectileController CreateProjectileObj(SkillData skillData, IEffectTarget target, float aoeMultiplierBonus, float duration)
		{
			return null;
		}

		private ProjectileEvents CreateProjectileEvents(SkillData skillData, EffectController effectController, ProjectileController projectileController)
		{
			return null;
		}

		private Action<IEffectTarget> CreateProjectileHitEvent(SkillData skillData, EffectController effectController, ProjectileController projectileObj)
		{
			return null;
		}

		private Action CreateProjectileEndEvent(ProjectileController projectileObj)
		{
			return null;
		}

		private void SetupHandlingIncomingDamage(ProjectileController projectileObj, ProjectileEvents projectileEvents, IEffectTarget plannedTarget, float incommingDamage)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
