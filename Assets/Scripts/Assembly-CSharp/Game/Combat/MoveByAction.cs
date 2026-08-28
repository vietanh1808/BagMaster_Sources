using UnityEngine;

namespace Game.Combat
{
	public class MoveByAction : MoveToAction
	{
		public MoveByAction(Transform transform, Vector2 motion)
			: base(null, default)
		{
		}

		public override void Execute()
		{
		}
	}
}
