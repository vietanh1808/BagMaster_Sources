using Combat.Dungeon;
using Game.Combat.SkillSystem;

namespace Game.Combat
{
	public class PlayerProfile
	{
		public readonly int Id;

		public readonly PlayerUnit PlayerUnit;

		public readonly Bag Bag;

		public bool IsAlive;

		public readonly IExpManager ExpManager;

		public readonly SkillSwapManager SkillSwap;

		public readonly PlayerPassiveManager PassiveManager;

		public PlayerProfile(int id, PlayerUnit playerUnit, Bag bag, IExpManager expManager = null)
		{
		}
	}
}
