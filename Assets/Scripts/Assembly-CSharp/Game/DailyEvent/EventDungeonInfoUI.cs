using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.DailyEvent
{
	public class EventDungeonInfoUI : MonoBehaviour
	{
		private static EventUnlockData _lastestEventDataOpened;

		private static EventDungeonData _lastestDungeonDataOpened;

		[SerializeField]
		private Image _banner;

		[SerializeField]
		private TextMeshProUGUI _eventNameTxt;

		[SerializeField]
		private TextMeshProUGUI _monsterBuffDescTxt;

		[SerializeField]
		private TextMeshProUGUI _playerBuffDescTxt;

		[SerializeField]
		private TextMeshProUGUI _levelTxt;

		[SerializeField]
		private Image _ticketIcon;

		[SerializeField]
		private TextMeshProUGUI _ticketHasTxt;

		[SerializeField]
		private GameObject _rewardItemTemplate;

		[SerializeField]
		private Button _challengeBtn;

		[SerializeField]
		private Button _sweepPreviousBtn;

		[SerializeField]
		private RewardPackUI _sweepRewardUI;

		private EventUnlockData _eventData;

		private EventDungeonData _dungeonData;

		private EventTicketData _eventTicketData;

		private PlayerInfo PInfo => null;

		private EventDungeonData.DungeonLevel Current => null;

		private EventDungeonData.DungeonLevel Previous => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateInfo(EventUnlockData eventData, EventDungeonData dungeonData)
		{
		}

		public void Challenge()
		{
		}

		public void SweepPrevious()
		{
		}

		public void Complete()
		{
		}
	}
}
