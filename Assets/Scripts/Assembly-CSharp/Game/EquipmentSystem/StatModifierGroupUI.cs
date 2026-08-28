using System.Collections.Generic;
using UnityEngine;

namespace Game.EquipmentSystem
{
	public class StatModifierGroupUI : MonoBehaviour
	{
		[SerializeField]
		private Transform itemContainer;

		[SerializeField]
		private StatModifierInfoUI itemPrefab;

		[SerializeField]
		private List<StatModifierInfoUI> pool;

		public void UpdateInfo(EquipmentLevelData levelData)
		{
		}
	}
}
