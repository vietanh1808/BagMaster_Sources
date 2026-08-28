using System.Collections.Generic;
using Game.Constant;

namespace Game.Combat
{
	public class TraitShopBuffSpawnService
	{
		private class GroupSave : IHasWeight
		{
			public List<BuffData> Buffs;

			public int CurrentLevel;

			public bool IsMaxLevel => false;

			public BuffData LowestLevelBuff => null;

			public int Weight => 0;

			public void Next()
			{
			}
		}

		private static readonly Rarity[] AllRarities;

		private bool _initialized;

		private Dictionary<int, GroupSave> _buffGroupSave;

		private Dictionary<Rarity, List<GroupSave>> _buffGroupSaveByRarity;

		private readonly HashSet<GroupSave> _shownThisOpen;

		public Rarity CurrentRarity { get; private set; }

		public void Initialize()
		{
		}

		public void AddToPool(BuffData buffData)
		{
		}

		public void SortBuffGroup()
		{
		}

		public void BeginOpen()
		{
		}

		public void PromoteGroup(BuffData buffData)
		{
		}

		public List<BuffData> GetRandomBuffs(Rarity rarity, List<BuffData> priorityBuffDatas, int numberItems)
		{
			return null;
		}

		public List<BuffData> GetRandomBuffs(Rarity rarity, int numberItems = 3)
		{
			return null;
		}

		private GroupSave PickGroup(Rarity rarity, List<GroupSave> usedGroups)
		{
			return null;
		}
	}
}
