using UnityEngine;

namespace Game
{
	public class SettingCTANotification : MonoBehaviour
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

		private bool HasAnySettingCTA()
		{
			return false;
		}

		private bool HasMailCTA()
		{
			return false;
		}

		private bool HasLoginCTA()
		{
			return false;
		}
	}
}
