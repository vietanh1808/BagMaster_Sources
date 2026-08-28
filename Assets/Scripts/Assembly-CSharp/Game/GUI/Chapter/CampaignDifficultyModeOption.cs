using I2.Loc;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GUI.Chapter
{
	public class CampaignDifficultyModeOption : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private RectTransform _selectionGlow;

		[SerializeField]
		private RectTransform _notificationIcon;

		[SerializeField]
		[Header("Lock")]
		private RectTransform _lockOverlay;

		[SerializeField]
		private LocalizationParamsManager _lockTextParamsManager;

		public void SetSelection(bool isSelected)
		{
		}

		public void SetNotification(bool hasNotification)
		{
		}

		public void Lock(string unlockCampaignName)
		{
		}

		public void Unlock()
		{
		}

		public void AddOnSelectListener(UnityAction onClickCallback)
		{
		}
	}
}
