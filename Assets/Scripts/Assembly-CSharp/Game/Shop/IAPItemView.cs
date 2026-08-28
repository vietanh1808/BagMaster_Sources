using DoorServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Game.Shop
{
	public class IAPItemView : MonoBehaviour, IIapOfferView
	{
		[Header("IAP")]
		public Button PurchaseButton;

		public TextMeshProUGUI PriceText;

		[SerializeField]
		private string _productId;

		[Header("Events")]
		public UnityEvent OnClaimedEvent;

		public string IapProductId => null;

		public StoreEntryMethod StoreEntryMethod { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Init(string iapProductId, StoreEntryMethod storeEntryMethod)
		{
		}

		private void MakePurchase()
		{
		}

		private void OnPurchaseSuccess(Order order)
		{
		}

		protected virtual void Claim(bool isIap)
		{
		}
	}
}
