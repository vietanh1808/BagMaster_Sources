using Combat.Dungeon;
using Game.Combat;

namespace Game
{
	public static class ExpExtensions
	{
		public static ExpMilestoneData GetCurrentMilestoneData(this IExpManager expManager)
		{
			return default;
		}

		public static bool IsMilestoneMaxed(this IExpManager expManager)
		{
			return false;
		}
	}
}
