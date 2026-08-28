using System;
using System.Runtime.CompilerServices;

namespace Game.Combat
{
	public class FloatGearSpriteAnimationService : SafeDisposeable, IFloatGearAnimationStopable
	{
		[CompilerGenerated]
		private Action m_OnStopped;

		private readonly SpriteMultiplierAnimation _spriteMultiplierAnimation;

		private readonly FloatGearSpriteAnimationProfile _profile;

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

		public FloatGearSpriteAnimationService(SpriteMultiplierAnimation spriteMultiplierAnimation, FloatGearSpriteAnimationProfile profile)
		{
		}

		protected override void DoDispose()
		{
		}

		private void CallOnStopped()
		{
		}

		public bool IsPlaying()
		{
			return false;
		}

		public void Play(float timeScale)
		{
		}

		public void Stop()
		{
		}
	}
}
