using System.Collections.Generic;
using Game.Combat.SkillSystem;

namespace Game.DailyEvent
{
	public class EventDungeonData
	{
		public class DungeonLevel
		{
			private RewardPack _reward;

			private SkillData _heroBuff;

			private SkillData _monsterBuff;

			private int _levelId;

			private int _rewardId;

			private int _heroBuffId;

			private int _monsterBuffId;

			public int LevelId => 0;

			public int RewardId => 0;

			public RewardPack Reward => null;

			public SkillData HeroBuff => null;

			public SkillData MonsterBuff => null;

			public DungeonLevel(int levelId, int rewardId, int heroBuffId, int monsterBuffId)
			{
			}
		}

		public int Id;

		public Dictionary<int, DungeonLevel> LevelData;
	}
}
