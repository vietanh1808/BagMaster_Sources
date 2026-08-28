using System;
using System.Runtime.CompilerServices;

namespace Game.Combat
{
	public class GearMergeService : IMergeService
	{
		[CompilerGenerated]
		private Action<IMergeableItem> m_OnRemovedByMergingEvent;

		[CompilerGenerated]
		private Action<IMergeableItem> m_OnMergedEvent;

		private readonly Unit _player;

		public event Action<IMergeableItem> OnRemovedByMergingEvent
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

		public event Action<IMergeableItem> OnMergedEvent
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

		public GearMergeService(Unit player)
		{
		}

		public bool CanMerge(IMergeableItem item1, IMergeableItem item2)
		{
			return false;
		}

		public bool TryMerging(IMergeableItem item1, IMergeableItem item2)
		{
			return false;
		}

		public bool TryMergingGear(Gear gear1, Gear gear2)
		{
			return false;
		}

		private void TriggerMergeableHint(Gear justMerged)
		{
		}
	}
}
