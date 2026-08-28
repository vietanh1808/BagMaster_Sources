using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Shop
{
	public class GachaChestAdsDrawView : MonoBehaviour
	{
		[SerializeField]
		private Button _drawButton;

		[SerializeField]
		private Button _noAdsButton;

		[SerializeField]
		private GameObject _noAdsGroup;

		[SerializeField]
		private GameObject _haveAdsGroup;

		[SerializeField]
		private TextMeshProUGUI _adsPurchaseRemainText;

		[SerializeField]
		private string _noAdsMessage;

		[Header("Events")]
		public UnityEvent OnDrewEvent;

		[Header("Runtime")]
		private bool _hasAds;

		private GachaChestAdsService _gachaChestAdsService;

		private void Start()
		{
		}

		private void OnDrawButtonClicked()
		{
		}

		private void OnNoAdsButtonClicked()
		{
		}

		private void HandleDraw()
		{
		}

		private void OnRewarded()
		{
		}

		public void UpdateInfo(GachaChestAdsService gachaChestAdsService)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void SetHasAds(bool value)
		{
		}

		private void UpdateAdsRemainText()
		{
		}
	}
}
