using System.Collections.Generic;
using UnityEngine;

namespace Game.Shop
{
	public class ShopPanel : MonoBehaviour
	{
		[SerializeField]
		private string _shopId;

		[SerializeField]
		private List<GameObject> _items;

		private void OnEnable()
		{
		}
	}
}
