using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class BlackMarketDisableRefreshButton : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private TextMeshProUGUI _countdownText;

		[SerializeField]
		private string _countdownFormat;

		[SerializeField]
		private float _toastDuration;

		private long _countdownSeconds;

		private void Start()
		{
		}

		private void OnClick()
		{
		}

		public void SetVisible(bool visible)
		{
		}

		public void SetCountdown(long seconds)
		{
		}
	}
}
