using System;
using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.EquipmentSystem
{
	[CreateAssetMenu(fileName = "EquipmentInfoRarityData", menuName = "Equipment/EquipmentInfoRarityData", order = 0)]
	public class EquipmentInfoRarityData : ScriptableObject
	{
		[Serializable]
		public class RarityVisualData
		{
			public Rarity Rarity;

			public EquipmentInfoVisualData[] Visuals;
		}

		[SerializeField]
		private List<RarityVisualData> _rarityVisualDatas;

		[SerializeField]
		private Sprite[] _tierIcons;

		public EquipmentInfoVisualData GetRarityVisualData(Rarity rarity, int rarityLevel)
		{
			return null;
		}

		public Sprite GetTierIcon(int tier)
		{
			return null;
		}
	}
}
