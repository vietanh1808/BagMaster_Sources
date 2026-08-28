using UnityEngine;

namespace Game.Combat
{
	public class MoveToAction : MonsterBehaviourAction
	{
		protected Transform _self;

		protected IStatHolder _statHolder;

		protected Vector2 _destination;

		public MoveToAction(Transform transform, Vector2 destination)
		{
		}

		public override void Execute()
		{
		}
	}
}
