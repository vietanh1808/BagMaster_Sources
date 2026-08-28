using System;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "BuffUIProfile", menuName = "Game/BuffUIProfile", order = 0)]
	public class BuffUIProfile : ScriptableObject
	{
		[Serializable]
		public class RarityData
		{
			[field: SerializeField]
			public Sprite BackgroundSprite { get; private set; }

			[field: SerializeField]
			public Sprite BorderSprite { get; private set; }
		}

		[SerializeField]
		private RarityData[] _rarityDatas;

		public RarityData Get(Rarity rarity)
		{
			return null;
		}
	}
}
