using System;

namespace Game.Combat
{
	public interface IFloatGearAnimationStopable
	{
		event Action OnStopped;

		bool IsPlaying();

		void Stop();
	}
}
