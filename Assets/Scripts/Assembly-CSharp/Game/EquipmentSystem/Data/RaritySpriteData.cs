using System;
using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.EquipmentSystem.Data
{
	[CreateAssetMenu(fileName = "RaritySpriteData", menuName = "Game/RaritySpriteData")]
	public class RaritySpriteData : ScriptableObject
	{
		[Serializable]
		private class RarityData
		{
			public Rarity Rarity;

			public Sprite[] Sprites;
		}

		[SerializeField]
		private List<RarityData> _rarityDatas;

		public Sprite GetSprite(Rarity rarity, int rarityLevel)
		{
			return null;
		}
	}
}
