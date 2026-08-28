using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public struct RangePosition
	{
		public enum PositionType
		{
			Self = 0,
			Enemy = 1
		}

		public PositionType Type;

		public Vector3 Offset;
	}
}
