using System.Collections.Generic;
using R3;
using UnityEngine;

namespace Game.Shop
{
	public class CategoryShopCTANotification : MonoBehaviour
	{
		[SerializeField]
		protected ShopCategory _category;

		[SerializeField]
		protected ShopCategory[] _otherCategories;

		[SerializeField]
		private GameObject _notification;

		private DisposableBag _disposableBag;

		private List<ShopPackData> _freeablePackDatas;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Check()
		{
		}
	}
}
