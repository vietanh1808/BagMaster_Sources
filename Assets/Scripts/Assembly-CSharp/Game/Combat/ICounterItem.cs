using UnityEngine;

namespace Game.Combat
{
	public interface ICounterItem
	{
		Transform GetTranform();

		float GetWidth();

		void OnDrop();
	}
}
