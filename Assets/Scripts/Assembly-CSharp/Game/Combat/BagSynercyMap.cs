using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Game.Combat
{
	public class BagSynercyMap
	{
		public class Data
		{
			public IBagGridItem ItemGiven;

			public IBagGridItem ItemReceived;

			public ActivateBaseOnGearNearbyComponent Source;
		}

		public class DataComparer : IEqualityComparer<Data>
		{
			public bool Equals(Data x, Data y)
			{
				return false;
			}

			public int GetHashCode(Data obj)
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private Action m_OnUpdated;

		private readonly BagGridMap _gridMap;

		private readonly PlayerPassiveManager _playerPassiveManager;

		private IEnumerable<Data> _datas;

		public event Action OnUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public BagSynercyMap(BagGridMap gridMap, PlayerPassiveManager playerPassiveManager)
		{
		}

		public void CancelItemEffect(IBagGridItem item)
		{
		}

		public IEnumerable<Data> GetSynercyDatas()
		{
			return null;
		}

		public IReadOnlyCollection<Data> GetRelatives(IBagGridItem item)
		{
			return null;
		}

		public void UpdateMap(IBagGridItem placingItem)
		{
		}

		private void BuildSynercyNearbyMap(IEnumerable<IBagGridItem> items)
		{
		}

		private void GetSynercyFromSkill(IBagGridItem given, SimpleSkill skill, List<Data> container)
		{
		}
	}
}
