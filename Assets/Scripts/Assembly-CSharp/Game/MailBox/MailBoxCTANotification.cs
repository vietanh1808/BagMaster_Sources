using UnityEngine;

namespace Game.MailBox
{
	public class MailBoxCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private bool _hasEventListener;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		public void Check()
		{
		}

		private bool HasUnclaimedMailRewards()
		{
			return false;
		}
	}
}
