using Game;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoPopupHolder : AutoPositionPopup
{
	[Header("Item Info")]
	[SerializeField]
	private TextMeshProUGUI _itemTitle;

	[SerializeField]
	private Image _itemIcon;

	[SerializeField]
	private TextMeshProUGUI _itemAmount;

	[SerializeField]
	private LocalizationParamsManager _itemOwnedAmount;

	[SerializeField]
	private TextMeshProUGUI _itemDescription;

	[SerializeField]
	private GameObject _owned;

	public void UpdateInfo(CurrencyView currencyView)
	{
	}

	public void UpdateInfo(int itemId, int amount)
	{
	}

	public void UpdateInfo(ResourceEntityHasVisual resource, int amount)
	{
	}

	public void Pop()
	{
	}

	public static void Show(ResourceEntityHasVisual resource, int amount, Transform anchor)
	{
	}

	public static void Show(int itemId, int amount, Transform anchor)
	{
	}
}
