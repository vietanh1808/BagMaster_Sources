using System.Collections.Generic;
using Game.Constant;

namespace Game.Combat
{
	public class RarityPool<TEntity> where TEntity : class
	{
		public class PoolItem
		{
			public TEntity Entity;

			public int Count;
		}

		public delegate bool EntityValidate(TEntity entity);

		private Dictionary<Rarity, List<PoolItem>> _pool;

		public void InitializePool()
		{
		}

		public void Add(Rarity rarity, TEntity entity, int count)
		{
		}

		public void Remove(Rarity rarity, TEntity entity)
		{
		}

		public void RemoveAll()
		{
		}

		public TEntity GetRandomly(Rarity rarity, EntityValidate entityValidate)
		{
			return null;
		}

		public TEntity GetRandomGearDataWithWeight(Rarity rarity, EntityValidate entityValidate, List<Gear> referenceGears, LevelData level = null)
		{
			return null;
		}

		public TEntity GetRandomlyAllRarities()
		{
			return null;
		}

		public bool Contains(Rarity rarity, TEntity entity)
		{
			return false;
		}
	}
}
