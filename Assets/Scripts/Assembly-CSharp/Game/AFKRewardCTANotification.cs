using TMPro;
using UnityEngine;

namespace Game
{
	public class AFKRewardCTANotification : MonoBehaviour
	{
		public enum CTAType
		{
			None = 0,
			Common = 1,
			QuickMine = 2
		}

		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private GameObject _notificationQuickMine;

		[SerializeField]
		private TextMeshProUGUI _quickMineCountText;

		[SerializeField]
		private bool _hasEventListener;

		[Header("Runtime")]
		[SerializeField]
		private CTAType _ctaType;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		public void Check()
		{
		}

		private bool IsQuickMineUnlocked()
		{
			return false;
		}

		private bool HasQuickMineCharge(out int count)
		{
			count = default;
			return false;
		}
	}
}
