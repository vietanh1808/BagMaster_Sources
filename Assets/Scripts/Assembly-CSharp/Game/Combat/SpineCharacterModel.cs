using Spine.Unity;
using UnityEngine;

namespace Game.Combat
{
	public class SpineCharacterModel : CharacterModel
	{
		private SkeletonAnimation _spine;

		private void Awake()
		{
		}

		public override bool IsMoving()
		{
			return false;
		}

		public override void PlayAnimation(string animationName)
		{
		}

		public override void PlayMoveAnimation()
		{
		}

		public override void PlayAttackAnimation()
		{
		}

		public override void PlayDieAnimation()
		{
		}

		public override void SetSpeed(float value)
		{
		}

		public override Color GetColor()
		{
			return default;
		}

		public override void SetColor(Color color)
		{
		}
	}
}
