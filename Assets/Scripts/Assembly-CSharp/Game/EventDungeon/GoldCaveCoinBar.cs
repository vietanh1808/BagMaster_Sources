using Game.Combat;
using UnityEngine;

namespace Game.EventDungeon
{
	public class GoldCaveCoinBar : GoldBar
	{
		protected override void Awake()
		{
		}

		private void OnValueChange(int obj)
		{
		}

		protected override void ListenRewardChanged(OwnedResourceEntity res, int changes)
		{
		}

		protected override void CreateCoinFX(int amount, int i, Vector2 destination, Vector2 spawnPosition)
		{
		}

		protected override int GetAutoUpdateValue()
		{
			return 0;
		}
	}
}
