using System.Collections.Generic;
using Game.Combat;
using Game.GearUpgrade;
using UnityEngine;

namespace Game.Arena
{
	public class ArenaInfoPlayerGearView : MonoBehaviour
	{
		[SerializeField]
		private List<GearUIItem> _items;

		private int _itemIndex;

		public void SetPlayerData(PlayerInfo playerInfo)
		{
		}

		private void CreateGearItem(GearData gearData, PlayerInfo playerInfo)
		{
		}
	}
}
