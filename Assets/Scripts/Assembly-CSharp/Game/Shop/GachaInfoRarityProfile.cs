using System;
using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.Shop
{
	[CreateAssetMenu(fileName = "GachaInfoRarityProfile", menuName = "Game/GachaInfoRarityProfile", order = 0)]
	public class GachaInfoRarityProfile : ScriptableObject
	{
		[Serializable]
		public class ProfileData
		{
			[field: SerializeField]
			public string RarityName { get; private set; }

			[field: SerializeField]
			public Color HeaderColor1 { get; private set; }

			[field: SerializeField]
			public Color HeaderColor2 { get; private set; }
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
