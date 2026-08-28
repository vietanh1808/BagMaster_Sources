using System;
using Game.Combat;

namespace Combat.Dungeon
{
	public interface IExpManager
	{
		int TotalExp { get; }

		int CurrentMilestone { get; }

		ExpMilestoneGroup MilestoneGroup { get; }

		event Action<int> OnMilestoneReached;
	}
}
