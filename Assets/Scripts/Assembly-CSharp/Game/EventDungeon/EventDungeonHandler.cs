using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class EventDungeonHandler : MonoBehaviour
	{
		[SerializeField]
		private Button buttonEntry;

		[SerializeField]
		private GameObject notificationObject;

		[SerializeField]
		private GameObject adsBuyTicketNotificationObject;

		[SerializeField]
		private TextMeshProUGUI adsBuyTicketNotificationText;

		[SerializeField]
		private FeatureUI featureUI;

		public GameObject iconObj;

		public Button ButtonEntry => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTicketChanged(EventDungeonUnlockViewState state)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void AssignFeatureUILockConditions()
		{
		}

		private void OnTimeUpdated()
		{
		}

		private void OnOpenEventWindow()
		{
		}

		private void CreateProgresses()
		{
		}

		private void RefreshData()
		{
		}

		private bool CheckForAnyEventUnlocked(IEnumerable<EventDungeonUnlockViewState> eventDungeons)
		{
			return false;
		}

		private bool CheckForAnyEventHasTickets(IEnumerable<EventDungeonUnlockViewState> eventDungeons)
		{
			return false;
		}
	}
}
