using System.Collections.Generic;
using Game.Talent;

namespace Game
{
	public class TalentSystemDataProvider : IDataProvider
	{
		private PlayerInfo PInfo => null;

		public IReadOnlyList<TalentData> GetAllTalentDatas()
		{
			return null;
		}

		public string GetCostIcon(int costId)
		{
			return null;
		}

		public string GetTranslation(string key, params string[] objs)
		{
			return null;
		}

		public bool IsUpgradeCostEnough(TalentUpgradeCostData cost)
		{
			return false;
		}

		public void SpendUpgradeCosts(List<TalentUpgradeCostData> costs)
		{
		}

		public void ApplyTalentEffect(TalentData data)
		{
		}

		public bool IsLastNormalTalentUpgraded(int requireLevel)
		{
			return false;
		}

		public string FormatNumberText(int number)
		{
			return null;
		}

		public int GetMainCampaignProgress()
		{
			return 0;
		}

		public int GetTalent0Progress()
		{
			return 0;
		}

		public int GetTalent1Progress()
		{
			return 0;
		}

		public void IncreaseTalent0Progress()
		{
		}

		public void IncreaseTalent1Progress()
		{
		}

		public bool GoToEventDungeon(string lockedMessage)
		{
			return false;
		}
	}
}
