using UnityEngine;

namespace Game.Combat
{
	public class CharacterModelAnimator : CharacterModel
	{
		private static readonly int Color1;

		public SpriteRenderer spriteRenderer;

		public Animator animator;

		protected virtual void Awake()
		{
		}

		public override bool IsMoving()
		{
			return false;
		}

		public override void PlayAnimation(string animationName)
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

		public override void SetMaterialColor(Color color)
		{
		}

		public override Transform GetRendererTransform()
		{
			return null;
		}

		public override string GetSortingLayerName()
		{
			return null;
		}

		public override void SetSortingLayer(string sortingLayerName)
		{
		}

		public override int GetSortingOrder()
		{
			return 0;
		}

		public override void SetSortingOrder(int sortingOrder)
		{
		}

		public override GameObject GetRendererGameObject()
		{
			return null;
		}
	}
}
