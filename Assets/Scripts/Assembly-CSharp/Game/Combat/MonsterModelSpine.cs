using Game.Tools;
using Spine.Unity;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterModelSpine : CharacterModel, IUpdater
	{
		private static readonly int Color1;

		[Header("Spine")]
		[SerializeField]
		private MeshRenderer meshRenderer;

		[SerializeField]
		private SkeletonMecanim skeletonMecanim;

		[SerializeField]
		private Animator animator;

		[Header("Move")]
		[SerializeField]
		private string moveTriggerName;

		[SerializeField]
		private float moveAnimationDuration;

		[Header("Attack")]
		[SerializeField]
		private string attackTriggerName;

		[SerializeField]
		private float attackAnimationDuration;

		private float _animationEndTime;

		private float _timer;

		private string _currentAnimation;

		private bool _currentAnimationCompleted;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void CustomUpdate(float dt)
		{
		}

		private void OnEndAnimation()
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
