using System;
using System.Collections.Generic;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

namespace Game.MailBox
{
	public class Page_MailBoxPopup_SpecificVIew : MonoBehaviour
	{
		[Header("UI Links")]
		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private List<Button> _closeButtonAlt;

		[SerializeField]
		private Button _claimRewardButton;

		[SerializeField]
		private Localize _mailTitleText;

		[SerializeField]
		private List<Localize> _contentText;

		[SerializeField]
		private GameObject _noRewardGroup;

		[SerializeField]
		private GameObject _hasRewardGroup;

		[SerializeField]
		private List<ResourceView> _resourceViews;

		private Mail_Content_DTO _mailContent;

		private Action _onClosed;

		private Action _onClaimed;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCloseButtonClicked()
		{
		}

		private void OnClaimRewardButtonClicked()
		{
		}

		public void UpdateInfo(Mail_Content_DTO mailContent, Action onClaimed = null, Action onClosed = null)
		{
		}

		private void UpdateGeneralInfo()
		{
		}

		private void UpdateState()
		{
		}

		private void UpdateRewards()
		{
		}
	}
}
