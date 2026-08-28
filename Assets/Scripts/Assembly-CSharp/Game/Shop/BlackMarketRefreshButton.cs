using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class BlackMarketRefreshButton : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private TextMeshProUGUI _countText;

		[SerializeField]
		private CurrencyView _priceView;

		[SerializeField]
		private TextMeshProUGUI _countdownText;

		[SerializeField]
		private string _countFormat;

		[SerializeField]
		private string _countdownFormat;

		public Action<bool> OnRefreshGranted;

		protected ResourceRequireData CurrentCost { get; private set; }

		protected virtual void Start()
		{
		}

		protected virtual void OnClick()
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetCount(int remaining, int max)
		{
		}

		public void SetPrice(ResourceRequireData cost)
		{
		}
	}
}
