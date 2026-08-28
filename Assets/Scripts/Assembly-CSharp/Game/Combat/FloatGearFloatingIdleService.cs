using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class FloatGearFloatingIdleService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStopped;

		private readonly FloatGearFloatingIdleProfile _profile;

		private readonly Transform _animatedTransform;

		private Tween _floatingTween;

		private Vector3 _initialPosition;

		public event Action OnStopped
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public FloatGearFloatingIdleService(FloatGearFloatingIdleProfile profile, Transform transform, Vector3 initialPosition)
		{
		}

		protected override void DoDispose()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Play(bool hasDelay)
		{
		}

		public void Stop()
		{
		}
	}
}
