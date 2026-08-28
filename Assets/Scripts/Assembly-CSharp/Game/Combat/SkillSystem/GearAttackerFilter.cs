using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class GearAttackerFilter
	{
		private class SortData
		{
			public Unit Unit;

			public float Compare;

			public bool InAttackRange;
		}

		private readonly Transform _owner;

		private readonly LayerMask _targetLayerMask;

		private readonly FilterMethod _filterMethod;

		private Collider2D _latestTarget;

		public GearAttackerFilter(Transform owner, LayerMask targetLayerMask, FilterMethod filterMethod = FilterMethod.Nearest)
		{
		}

		public void Find(int targetCount, bool mustFillEnoughTargetCount, float attackRange, float observerRange, out List<IEffectTarget> inAtackRange, out List<IEffectTarget> inObserverRange)
		{
			inAtackRange = null;
			inObserverRange = null;
		}

		private int Sort(SortData x, SortData y)
		{
			return 0;
		}
	}
}
