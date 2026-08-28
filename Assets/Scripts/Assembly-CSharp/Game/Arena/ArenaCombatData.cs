using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game.Arena
{
	public class ArenaCombatData
	{
		public Vector2 Player1Position;

		public Vector2 Player2Position;

		public int[] BuffIds;

		public int[] Player1SkillIds;

		public int[] Player2SkillIds;

		public int[] RandomGearIds;

		public int GearCount;

		public List<LevelStartGear> StartGears;

		public string BackgroundPath;

		public LevelData GetLevelData()
		{
			return null;
		}
	}
}
