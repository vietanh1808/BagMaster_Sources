using System.Collections.Generic;
using EnhancedUI.EnhancedScroller;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.MailBox
{
	public class Mail_ListItem : EnhancedScrollerCellView
	{
		[Header("UI Links")]
		[SerializeField]
		private Localize _titleText;

		[SerializeField]
		private Localize _contentText;

		[SerializeField]
		private TextMeshProUGUI _sentTimeText;

		[SerializeField]
		private GameObject _notificationIcon;

		[SerializeField]
		private GameObject _readBackground;

		[SerializeField]
		private List<ResourceView> _resourceViews;

		[SerializeField]
		private Button _openButton;

		[Header("UI Icons links")]
		[SerializeField]
		private GameObject _hasAttachmentIcon;

		[SerializeField]
		private GameObject _unreadIcon;

		[SerializeField]
		private GameObject _readIcon;

		[Header("Events")]
		public UnityEvent OnClickedEvent;

		[Header("References")]
		public Page_MailBoxPopup_SpecificVIew ViewPopup;

		private Mail_Content_DTO _mailContent;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnListItemClickedHandler()
		{
		}

		public void UpdateInfo(Mail_Content_DTO data)
		{
		}

		public override void RefreshCellView()
		{
		}

		private void SetState()
		{
		}
	}
}
