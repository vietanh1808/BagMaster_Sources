using System;
using Game.QuestSystem;

namespace Game
{
	public class QuestSystemSaver : IQuestProgressProvider
	{
		private PlayerInfo PInfo => null;

		public int GetProgress(int questId)
		{
			return 0;
		}

		public void SetProgress(int questId, int value)
		{
		}

		public void CompleteQuest(int questId)
		{
		}

		public void ResetQuestCompletedTime(int questId)
		{
		}

		public bool IsQuestEverCompleted(int questId)
		{
			return false;
		}

		public DateTime GetLatestCompletedTime(int questId)
		{
			return default;
		}

		public int GetCampaignProgress()
		{
			return 0;
		}

		public int GetDungeonProgress(int dungeonId)
		{
			return 0;
		}

		public bool IsCampaginCleared(int campaignId)
		{
			return false;
		}

		public bool IsDungeonCleared(int dungeonId, int dungeonLevel)
		{
			return false;
		}

		public int GetEquipmentLevel(int levelId)
		{
			return 0;
		}

		public int GetTalentProgress(int talentId)
		{
			return 0;
		}
	}
}
