using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class RecycleChargeRefillPopup : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _refillCountText;

		[SerializeField]
		private string _refillCountTextFormat;

		[SerializeField]
		private Button _refillButton;

		[Header("Runtime")]
		[SerializeField]
		public RecyleDropArea Recycle;

		[SerializeField]
		public int RefillNumber;

		private bool _waitingAdsResponse;

		private void Start()
		{
		}

		public void WatchAdsRefill()
		{
		}
	}
}
