using System;
using System.Collections.Generic;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class AFKRewardPanel : MonoBehaviour
	{
		[SerializeField]
		private LocalizationParamsManager _totalTimeText;

		[SerializeField]
		private TextMeshProUGUI _claimableText;

		[SerializeField]
		private LocalizationParamsManager _timeToClaimText;

		[SerializeField]
		private Button _claimButton;

		[SerializeField]
		private Sprite _claimButtonDisabledSprite;

		[SerializeField]
		private LocalizationParamsManager _goldPerTickView;

		[SerializeField]
		private List<ResourceView> _rewardViews;

		[SerializeField]
		private GameObject _nonclaimableSprite;

		[SerializeField]
		private LocalizationParamsManager _descriptionText;

		[SerializeField]
		private GameObject _afkClaimNotification;

		[Header("Runtime")]
		[SerializeField]
		private bool _isClaimable;

		private Sprite _claimableSprite;

		private string _notClaimPrefixStr;

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void UpdateTimer()
		{
		}

		private void UpdateMaxTime()
		{
		}

		private void UpdateUI()
		{
		}

		private int SortByRarity(ResourceView x, ResourceView y)
		{
			return 0;
		}

		private void UpdateClaimable(bool state, TimeSpan timeToClaim)
		{
		}

		public void ClaimReward()
		{
		}
	}
}
