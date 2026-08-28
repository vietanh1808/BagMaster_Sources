using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class TargetFinderGearNearby
	{
		private readonly Gear _gear;

		private readonly int _findById;

		private readonly string[] _findByTags;

		private readonly IReadOnlyCollection<Vector2Int> _positionOffsets;

		private readonly Func<IReadOnlyDictionary<Vector2Int, IBagGridItem>> _gridMapGetter;

		public IEnumerable<Vector2Int> Positions { get; private set; }

		public TargetFinderGearNearby(Gear gear, int targetId, string[] targetTags, IReadOnlyList<Vector2Int> positions, Func<IReadOnlyDictionary<Vector2Int, IBagGridItem>> gridMapGetter)
		{
		}

		public List<IEffectTarget> FindTarget()
		{
			return null;
		}

		public bool IsItemValid(IHasTags hasTagObject)
		{
			return false;
		}
	}
}
