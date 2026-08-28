using UnityEngine;

namespace Game
{
	public interface IRewardVisual
	{
		Sprite Icon { get; }

		string LocalizedName { get; }

		string LocalizedDesc { get; }
	}
}
