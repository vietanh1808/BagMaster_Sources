using System;
using System.Collections.Generic;

namespace Game
{
	public interface IReward
	{
		void Reward(int amount, string placement, bool claim, Action<List<ResourceRewardData>> receivedCallback);
	}
}
