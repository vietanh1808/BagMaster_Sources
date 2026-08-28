using EnhancedUI.EnhancedScroller;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArenaLeaderboardItemView : EnhancedScrollerCellView
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private GameObject indexTop1;

	[SerializeField]
	private GameObject indexTop2;

	[SerializeField]
	private GameObject indexTop3;

	[SerializeField]
	private GameObject indexOutTop;

	[SerializeField]
	private GameObject maskPlayer;

	[SerializeField]
	private TextMeshProUGUI textIndex;

	[SerializeField]
	private TextMeshProUGUI textName;

	[SerializeField]
	private TextMeshProUGUI textPoint;

	[SerializeField]
	private TextMeshProUGUI textPower;

	[SerializeField]
	private MMF_Player activeFeedback;

	private int userId;

	private void Awake()
	{
	}

	private void ClickItem()
	{
	}

	public void Initialize(int index, int userId, string userName, int point, int power, bool isPlayer = false)
	{
	}

	public void PlayActiveFeedback()
	{
	}
}
