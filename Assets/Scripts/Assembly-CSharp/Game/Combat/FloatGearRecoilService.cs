using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class FloatGearRecoilService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStopped;

		private readonly FloatGearRecoilProfile _profiles;

		private readonly Transform _recoilTransform;

		private Vector3 _initialPosition;

		private Tween _recoilTween;

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

		public FloatGearRecoilService(FloatGearRecoilProfile profiles, Transform recoilTransform)
		{
		}

		protected override void DoDispose()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Stop()
		{
		}

		public void Play(float signDirection = 1f)
		{
		}
	}
}
