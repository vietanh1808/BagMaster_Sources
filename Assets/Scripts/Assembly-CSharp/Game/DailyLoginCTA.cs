using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class DailyLoginCTA : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private bool _hasEventListener;

		[SerializeField]
		private int _lastDay;

		[SerializeField]
		private UnityEvent<bool> _onNotificationEvent;

		private bool _invokedNotification;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		public void Check()
		{
		}
	}
}
