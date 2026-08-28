using UnityEngine;

namespace Game.Combat
{
	public class PlayerInRangeCondition : MonsterBehaviourCondition
	{
		public Transform _self;

		private float _requireDistance;

		private bool _onlyX;

		public PlayerInRangeCondition(Transform transform, float requireDistance, bool onlyX)
		{
		}

		public override bool IsConditionOk()
		{
			return false;
		}
	}
}
