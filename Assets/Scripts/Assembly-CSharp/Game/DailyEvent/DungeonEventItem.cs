using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.DailyEvent
{
	public class DungeonEventItem : MonoBehaviour
	{
		[SerializeField]
		private Image _banner;

		[SerializeField]
		private TextMeshProUGUI _eventNameTxt;

		[SerializeField]
		private Image _rewardIcon;

		[SerializeField]
		private TextMeshProUGUI _rewardTxt;

		[SerializeField]
		private Image _ticketRequireIcon;

		[SerializeField]
		private TextMeshProUGUI _ticketOwnedTxt;

		[SerializeField]
		private TextMeshProUGUI _levelTxt;

		[SerializeField]
		private GameObject _lock;

		[SerializeField]
		private TextMeshProUGUI _unlockConditionTxt;

		[SerializeField]
		private GameObject _infoUI;

		private EventUnlockData _data;

		private EventTicketData _eventTicketData;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateInfo(EventUnlockData data)
		{
		}

		private void OnClick()
		{
		}
	}
}
