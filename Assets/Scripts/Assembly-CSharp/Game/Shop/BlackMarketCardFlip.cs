using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Game.Shop
{
	public class BlackMarketCardFlip : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _flipRoot;

		[SerializeField]
		private List<GameObject> _faceObjects;

		[SerializeField]
		private GameObject _cardBackObject;

		[SerializeField]
		private float _duration;

		[SerializeField]
		private float _revealAngle;

		[SerializeField]
		private Ease _ease;

		private Tween _tween;

		private bool _isFaceVisible;

		private void OnDisable()
		{
		}

		public void SetFaceDown()
		{
		}

		public void PlayFlip(float delay)
		{
		}

		public void ResetFlip()
		{
		}

		private void ApplyFlipAngle(float angle)
		{
		}

		private void SetFaceVisible(bool visible)
		{
		}
	}
}
