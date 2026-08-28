using UnityEngine;

namespace Game.Combat
{
	public interface IMergeableItem
	{
		GameObject MergeAppearVfx { get; }

		bool CanMerged(IMergeableItem other);

		void SetMergeable(IMergeableItem item);

		Transform GetTranform();
	}
}
