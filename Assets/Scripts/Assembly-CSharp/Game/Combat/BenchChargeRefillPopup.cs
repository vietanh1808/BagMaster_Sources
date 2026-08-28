using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class BenchChargeRefillPopup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _refillCountText;

		[SerializeField]
		private Button _refillButton;

		[SerializeField]
		private Button _cancelButton;

		[Header("Runtime")]
		[SerializeField]
		public BenchSlot Bench;

		[SerializeField]
		public int RefillNumber;

		private bool _waitingAdsResponse;

		private void Start()
		{
		}

		public void WatchAdsRefill()
		{
		}

		public void CancelAds()
		{
		}
	}
}
