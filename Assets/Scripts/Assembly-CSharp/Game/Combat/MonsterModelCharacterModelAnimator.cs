using Game.Tools;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterModelCharacterModelAnimator : CharacterModelAnimator, IUpdater
	{
		[SerializeField]
		private string speedMultiplierParamName;

		[SerializeField]
		private AnimationCurveData[] animationCurves;

		[SerializeField]
		private string moveTriggerName;

		[SerializeField]
		private float moveAnimationDuration;

		[SerializeField]
		private string attackTriggerName;

		[SerializeField]
		private float attackAnimationDuration;

		[SerializeField]
		private float attackHitTime;

		[SerializeField]
		private bool enableDebugLog;

		private float _animationEndTime;

		private float _attackHitTime;

		private float _timer;

		private string _currentAnimation;

		private bool _currentAnimationCompleted;

		private bool _waitAttackHit;

		private AnimationCurveData _currentCurveData;

		private float _currentAnimationStartTimer;

		private string _idleAnimationName;

		private int _idleAnimationHash;

		private bool _hasIdleAnimation;

		private int _moveAnimationHash;

		protected override void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override bool IsMoving()
		{
			return false;
		}

		public override bool IsAttacking()
		{
			return false;
		}

		public override void PlayAnimation(string animationName)
		{
		}

		public override void PlayMoveAnimation()
		{
		}

		public override void PlayAttackAnimation()
		{
		}

		public override void PlayIdleAnimation()
		{
		}

		public void CustomUpdate(float dt)
		{
		}

		public override void InvokeAttackHit()
		{
		}

		private void TrySetCurrentCurve(string stateName)
		{
		}

		private void OnEndAnimation()
		{
		}

		public void InitializeLegacy()
		{
		}

		public override void DisableCurrentAttack()
		{
		}

		private void AutoAccquire()
		{
		}
	}
}
