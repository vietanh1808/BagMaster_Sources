using System;
using System.Runtime.CompilerServices;
using DG.Tweening;

namespace Game.Combat
{
	public class FloatGearEmptyAnimationService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStopped;

		private Tween _durationTween;

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

		public bool IsPlaying()
		{
			return false;
		}

		public void Play(float duration)
		{
		}

		public void Stop()
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
