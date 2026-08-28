using System;

namespace Game.Combat
{
	public interface IMergeService
	{
		event Action<IMergeableItem> OnRemovedByMergingEvent;

		event Action<IMergeableItem> OnMergedEvent;

		bool CanMerge(IMergeableItem item1, IMergeableItem item2);

		bool TryMerging(IMergeableItem item1, IMergeableItem item2);
	}
}
