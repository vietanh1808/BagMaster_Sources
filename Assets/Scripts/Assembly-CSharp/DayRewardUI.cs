using System.Collections.Generic;
using I2.Loc;
using UnityEngine;
using UnityEngine.UI;

public class DayRewardUI : MonoBehaviour
{
	public enum DailyRewardUIState
	{
		AlreadyReceive = 0,
		NotReceive = 1,
		AbleToReceive = 2
	}

	[SerializeField]
	private DailyRewardUIState _state;

	public LocalizationParamsManager DayText;

	public List<DailyRewardIcon> dailyRewardIcons;

	[SerializeField]
	private Image _claimableDayImage;

	[SerializeField]
	private Sprite[] _claimableDaySprites;

	[SerializeField]
	private GameObject _claimUnderGlow;

	[SerializeField]
	private GameObject clearPanel;

	[SerializeField]
	private GameObject _receivePopup;

	[SerializeField]
	private GameObject _canClaimnNotification;

	[SerializeField]
	private GameObject _claimButton;

	[Header("Message")]
	[SerializeField]
	private string _notReceiveMessage;

	[SerializeField]
	private string _alreadyReceiveMessage;

	private DailyRewardSO dailyReward;

	public void Init(DailyRewardSO dailyRewardSO)
	{
	}

	private void OnDisable()
	{
	}

	public void SwitchState(DailyRewardUIState state)
	{
	}

	public void CheckforReward()
	{
	}

	private void ClaimReward()
	{
	}

	private void Claim(Dictionary<int, int> inventory)
	{
	}

	public DailyRewardUIState CurrentState()
	{
		return DailyRewardUIState.AlreadyReceive;
	}
}
