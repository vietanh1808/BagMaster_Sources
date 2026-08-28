using UnityEngine;

namespace Game
{
	public class SettingSubCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private bool _hasEventListener;

		private void Start()
		{
		}

		public void Check()
		{
		}

		private bool HasLoginCTA()
		{
			return false;
		}
	}
}
