using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class CharacterModel : MonoBehaviour
	{
		public UnityEvent onAttackCompletedEvent;

		public UnityEvent onAttackHitEvent;

		public float speed;

		public virtual bool IsMoving()
		{
			return false;
		}

		public virtual bool IsAttacking()
		{
			return false;
		}

		public virtual void PlayAnimation(string animationName)
		{
		}

		public virtual void PlayMoveAnimation()
		{
		}

		public virtual void PlayAttackAnimation()
		{
		}

		public virtual void PlayDieAnimation()
		{
		}

		public virtual void PlayIdleAnimation()
		{
		}

		public virtual void SetSpeed(float value)
		{
		}

		public virtual Color GetColor()
		{
			return default;
		}

		public virtual void SetColor(Color color)
		{
		}

		public virtual void SetMaterialColor(Color color)
		{
		}

		public virtual Transform GetRendererTransform()
		{
			return null;
		}

		public virtual string GetSortingLayerName()
		{
			return null;
		}

		public virtual void SetSortingLayer(string sortingLayerName)
		{
		}

		public virtual int GetSortingOrder()
		{
			return 0;
		}

		public virtual void SetSortingOrder(int sortingOrder)
		{
		}

		public virtual void InvokeAttackHit()
		{
		}

		public virtual GameObject GetRendererGameObject()
		{
			return null;
		}

		public virtual void DisableCurrentAttack()
		{
		}
	}
}
