using Game;
using UnityEngine;

public class DailyRewardIcon : MonoBehaviour
{
	public int itemId;

	[SerializeField]
	private ResourceView _currencyView;

	[SerializeField]
	private GameObject _receivePopup;

	[SerializeField]
	private GameObject _receiveButton;

	[SerializeField]
	private DayRewardUI _rewardUI;

	public ResourceView CurrencyView => null;

	private void OnEnable()
	{
	}
}
