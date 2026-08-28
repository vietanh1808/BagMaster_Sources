using System;
using System.Collections.Generic;

namespace Game.Combat
{
	public class TargetFinderAllGears
	{
		private Gear _gear;

		private Func<IEnumerable<Gear>> _gearsGetter;

		private int _findById;

		private string[] _findByTags;

		private bool _includeSelf;

		private int _maxTarget;

		private bool _shuffle;

		private CompareType _mergeLevelCompareType;

		private int _mergeLevelCompare;

		public TargetFinderAllGears(Gear gear, Func<IEnumerable<Gear>> gearsGetter, int targetId, string[] targetTags, bool includeSelf, int maxTarget = 2147483647, bool shuffle = false, CompareType mergeLevelCompareType = CompareType.Greater, int mergeLevelCompare = 0)
		{
		}

		public List<IEffectTarget> FindTarget()
		{
			return null;
		}

		public bool IsItemValid(IHasTags hasTagObject, Gear gear)
		{
			return false;
		}
	}
}
