using Game.Combat;

namespace Game.EventDungeon
{
	public class EventDungeonRevivePopup : RevivePopup
	{
		private EventDungeonViewState eventDungeon;

		private EventDungeonUnlockViewState eventDungeonUnlock;

		protected override void Start()
		{
		}

		protected override void RevivePlayer()
		{
		}

		protected override string GetDefeatPage()
		{
			return null;
		}

		protected override RewardPack GetLootRewards()
		{
			return null;
		}
	}
}
