using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Fuse
{
	public class Item : EquipmentInfo
	{
		[SerializeField]
		private EquipmentInfoGeneralUI _generalUI;

		[Header("UX")]
		[SerializeField]
		private GameObject _notificationUI;

		[SerializeField]
		private Button _button;

		[SerializeField]
		private GameObject _tick;

		[SerializeField]
		private GameObject _equipped;

		[Header("References")]
		[SerializeField]
		private FusePanel fuseTab;

		public bool CanPush => false;

		public GameObject NotificationUI => null;

		public void SetClickable(bool clickable)
		{
		}

		public void SetTick(bool active)
		{
		}

		public void SetNotification(bool active)
		{
		}

		public void PushOrPop()
		{
		}

		protected override void UpdateInfo()
		{
		}
	}
}
