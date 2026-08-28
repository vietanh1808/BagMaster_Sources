using System;
using System.Collections.Generic;
using Game.Combat.SkillSystem;
using UnityEngine;

namespace Game.Combat
{
	public class SkillAnimationService
	{
		private readonly Unit _owner;

		private readonly Gear _gear;

		private readonly SkillData _skillData;

		private readonly string _castingAnimation;

		private readonly Func<Transform> _floatGearGetter;

		private readonly Func<IReadOnlyList<IEffectTarget>> _targetsGetter;

		private FloatGearAnimator _cachedAnimator;

		public SkillAnimationService(Unit owner, Gear gear, SkillData skillData, string castingAnimation, Func<Transform> floatGearGetter, Func<IReadOnlyList<IEffectTarget>> targetsGetter)
		{
		}

		public bool InAnimation()
		{
			return false;
		}

		public void PlayAnimationOnCast(SkillCastData eventData)
		{
		}

		private void PlayAnimation(string animationData, SkillCastData castEventData)
		{
		}

		private void PlaySlashTowardTargetAnimation()
		{
		}

		private void PlayThrustTowardTargetAnimation()
		{
		}

		private void GetTowardTargetParameters(out float distance, out Vector3 attackDirection)
		{
			distance = default;
			attackDirection = default;
		}

		private float GetAoeMod()
		{
			return 0f;
		}

		private void PlayRecoilAnimation()
		{
		}

		private void PlaySpriteAnimation(string animationProfile)
		{
		}

		private void PlayAlphaAnimaiton(float duration)
		{
		}

		public void PlayDelay(float delay)
		{
		}

		public void PlayAnimator(string trigger)
		{
		}
	}
}
