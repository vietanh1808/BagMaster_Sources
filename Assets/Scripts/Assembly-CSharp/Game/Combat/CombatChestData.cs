using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.Combat
{
	public class CombatChestData
	{
		public int Id;

		public Sprite Icon;

		public string Note;

		public int CommonRate;

		public int UncommonRate;

		public int RareRate;

		public int EpicRate;

		public int LegendaryRate;

		public int MysticRate;

		public List<Rarity> GetRarities(int number)
		{
			return null;
		}
	}
}
