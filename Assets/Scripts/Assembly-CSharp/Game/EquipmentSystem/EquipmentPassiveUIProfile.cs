using System;
using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.EquipmentSystem
{
	[CreateAssetMenu(fileName = "EquipmentPassiveUIProfile", menuName = "Game/EquipmentPassiveUIProfile", order = 0)]
	public class EquipmentPassiveUIProfile : ScriptableObject
	{
		[Serializable]
		public class ProfileData
		{
			[SerializeField]
			public Sprite PassiveIcon;

			[SerializeField]
			public Sprite PassiveLockIcon;

			[SerializeField]
			public Color TextColor;

			[SerializeField]
			public Material FontMaterial;

			[field: SerializeField]
			public string RarityName { get; private set; }
		}

		[Serializable]
		public class RarityData
		{
			public Rarity Rarity;

			public List<ProfileData> ProfileDatas;
		}

		[SerializeField]
		private RarityData[] _rarityDatas;

		public ProfileData GetProfileData(Rarity rarity, int rarityLevel)
		{
			return null;
		}
	}
}
