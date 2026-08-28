using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class ShopNavigation : MonoBehaviour
	{
		[Serializable]
		private class ShopCategory
		{
			public Toggle Toggle;

			public GameObject On;

			public float NormalizedPosition;

			public Vector2 NormalizedPositionRange;
		}

		[SerializeField]
		private ScrollRect _scrollView;

		[SerializeField]
		private List<ShopCategory> _shopCategories;

		[SerializeField]
		private float _scrollDuration;

		private Tween _scrollTween;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void InitializeShopCategories()
		{
		}

		private void ShowCategory(ShopCategory category)
		{
		}
	}
}
