using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.Constant;

namespace Game.Combat
{
	public class GearSpawnWithRarityPoolService : IGearSpawnService, IGearLuckySpawnService
	{
		[CompilerGenerated]
		private Action<Gear> m_OnGearCreatedEvent;

		[CompilerGenerated]
		private Action<Gear> m_OnGearReceveidLuck;

		private readonly Unit _gearOwner;

		private readonly Func<IReadOnlyCollection<Rarity>> _raritiesGetter;

		private readonly Func<float> _luckGetter;

		private readonly Func<LevelData> _levelDataGetter;

		private readonly RarityPool<GearData> _pool;

		public event Action<Gear> OnGearCreatedEvent
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

		public event Action<Gear> OnGearReceveidLuck
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

		public GearSpawnWithRarityPoolService(Unit gearOwner, Func<IReadOnlyCollection<Rarity>> raritiesGetter, Func<float> luckGetter, Func<LevelData> levelDataGetter = null)
		{
		}

		public void Add(GearData gearData)
		{
		}

		public void Remove(GearData gearData)
		{
		}

		public Gear CreateGearWithID(GearData gearData)
		{
			return null;
		}

		public List<Gear> Spawn()
		{
			return null;
		}

		private Gear CreateGearFromPool(Rarity rarity, Predicate<GearData> predicate, List<Gear> referenceGears)
		{
			return null;
		}

		private GearData GetGearDataWithWeight(Rarity rarity, Predicate<GearData> predicate, List<Gear> referenceGears, LevelData level = null)
		{
			return null;
		}

		private GearData RollLuck(GearData gearData, out bool result)
		{
			result = default;
			return null;
		}
	}
}
