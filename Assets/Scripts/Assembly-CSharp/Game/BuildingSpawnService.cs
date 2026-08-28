using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.Combat;
using Game.Constant;
using UnityEngine;

namespace Game
{
	public class BuildingSpawnService
	{
		[CompilerGenerated]
		private Action<Building> m_OnBuildingCreatedEvent;

		private readonly GameObject _prefab;

		private readonly Func<Rarity> _rarityGetter;

		private readonly Predicate<KingdomBuildingData> _validator;

		private readonly RarityPool<KingdomBuildingData> _pool;

		public event Action<Building> OnBuildingCreatedEvent
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

		public BuildingSpawnService(GameObject prefab, Func<Rarity> rarityGetter, Predicate<KingdomBuildingData> validator)
		{
		}

		public List<GameObject> Spawn(int amount)
		{
			return null;
		}
	}
}
