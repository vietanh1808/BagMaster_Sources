using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	public class FloatGearAlphaAnimationService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStopped;

		private readonly FloatGearAlphaAnimationProfile _profile;

		private readonly SpriteRenderer _renderer;

		private Tween _fadeTween;

		private float _initialAlpha;

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

		public FloatGearAlphaAnimationService(FloatGearAlphaAnimationProfile profile, SpriteRenderer renderer)
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

		public void Play(float duration)
		{
		}
	}
}
