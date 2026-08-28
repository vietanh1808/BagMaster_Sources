using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	public class ChestData
	{
		public int Id;

		public Sprite Icon;

		public float LuckyRate;

		private Dictionary<Rarity, float> _normals;

		private Dictionary<Rarity, float> _ads;

		public void ChangeRate(Rarity rarity, float rate)
		{
		}

		public void ChangeRateAds(Rarity rarity, float rate)
		{
		}

		public List<Rarity> GetRarities(int number)
		{
			return null;
		}

		public List<Rarity> GetRaritiesOfAds(int number)
		{
			return null;
		}
	}
}
