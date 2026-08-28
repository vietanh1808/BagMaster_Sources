using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class FloatGearAnimator : MonoBehaviour
	{
		[Header("Idle")]
		[SerializeField]
		private Transform _idleTransform;

		[SerializeField]
		private FloatGearFloatingIdleProfile _idleProfile;

		[SerializeField]
		private bool _idleEnable;

		[Header("Recoil")]
		[SerializeField]
		private FloatGearRecoilProfile _recoilProfiles;

		[SerializeField]
		private Transform _recoilTransform;

		[Header("Slash")]
		[SerializeField]
		private FloatGearSlashingProfile _slashingProfile;

		[SerializeField]
		private Transform _slashTransform;

		[Header("Thrust")]
		[SerializeField]
		private FloatGearThrustProfile _thrustProfile;

		[SerializeField]
		private Transform _thrustTransform;

		[Header("Sprites")]
		[SerializeField]
		private FloatGearSpriteAnimationProfile _spriteProfile;

		[SerializeField]
		private SpriteMultiplierAnimation _spriteMultiplierAnimation;

		[Header("Alpha")]
		[SerializeField]
		private FloatGearAlphaAnimationProfile _alphaProfile;

		[SerializeField]
		private SpriteRenderer _alphaRenderer;

		[Header("Animator")]
		[SerializeField]
		private Animator _animator;

		[Header("Events")]
		public UnityEvent OnPlayEvent;

		public UnityEvent OnStopEvent;

		[Header("References")]
		public IEffectGear Gear;

		private FloatGearFloatingIdleService _idleService;

		private FloatGearRecoilService _recoilService;

		private FloatGearSlashingService _slashingService;

		private FloatGearThrustService _thrustService;

		private FloatGearSpriteAnimationService _spriteAnimationService;

		private FloatGearEmptyAnimationService _emptyAnimationService;

		private FloatGearAlphaAnimationService _alphaAnimationService;

		private FloatGearAnimatorAnimationService _animatorAnimationService;

		private List<IFloatGearAnimationStopable> _animationServices;

		private Vector3 _idleLocalPosition;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Stop()
		{
		}

		public void PlayIdle(bool firstPlay)
		{
		}

		public void PlayRecoil(float signDirection = 1f)
		{
		}

		public void PlaySlash(float distance, Vector3 direction, float slashUpRadius, float slashDownRadius, float forwardRadius, float timeScale, Action onStartSlash = null, Action onStopSlash = null, Action onStartBack = null)
		{
		}

		public void PlayThrust(float distance, Vector3 direction, float timeScale, Action onStartSlash = null, Action onStopSlash = null, Action onStartBack = null)
		{
		}

		public void PlayAnimationSprites(string profileName)
		{
		}

		public void PlayEmptyAnimation(float duration)
		{
		}

		public void PlayAlpha(float duration)
		{
		}

		public void PlayAninmator(string trigger)
		{
		}

		private void AddFloatGearAnimationStopable(IFloatGearAnimationStopable animation)
		{
		}

		private float GetAnimationSpeedMultiplier()
		{
			return 0f;
		}
	}
}
