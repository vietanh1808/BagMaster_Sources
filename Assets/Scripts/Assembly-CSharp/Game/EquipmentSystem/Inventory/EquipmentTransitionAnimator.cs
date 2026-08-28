using System;
using DG.Tweening;
using UnityEngine;

namespace Game.EquipmentSystem.Inventory
{
	public class EquipmentTransitionAnimator : MonoBehaviour
	{
		[SerializeField]
		private EquipmentInfo _flyItem;

		[SerializeField]
		private float _flyDuration;

		[SerializeField]
		private float _arrivalDelay;

		[SerializeField]
		private float _toScale;

		[SerializeField]
		private Ease _flyEase;

		[SerializeField]
		private GameObject _blockInteraction;

		[SerializeField]
		private CanvasGroup _blockInteractionWithCanvasGroup;

		private Tween _currentItemAnimation;

		public bool InAnimation()
		{
			return false;
		}

		public void CompleteItemAnimation()
		{
		}

		public void PlayPushingItem(EquipmentData equipmentData, Vector3 position, Vector3 destination, Action onCompleted)
		{
		}

		private void BlockInteraction(bool block)
		{
		}
	}
}
