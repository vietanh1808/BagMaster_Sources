using System.Collections.Generic;
using UnityEngine;

namespace Game.Shop
{
	public abstract class ShopByCategory : MonoBehaviour
	{
		[SerializeField]
		protected ShopCategory _category;

		[SerializeField]
		protected List<GameObject> _shopItems;

		protected List<ShopPackData> _packDatas;

		private bool _isStarted;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		private void LoadPackDatas()
		{
		}

		protected virtual void GenerateShopItems()
		{
		}
	}
}
