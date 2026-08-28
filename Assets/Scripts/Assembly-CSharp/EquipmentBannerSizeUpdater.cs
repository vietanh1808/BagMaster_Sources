using System.Collections.Generic;
using UnityEngine;

public class EquipmentBannerSizeUpdater : MonoBehaviour
{
	[Header("UI Link")]
	[SerializeField]
	private List<RectTransform> _equipmentBannerSlots;

	[SerializeField]
	private RectTransform _chestPanel;

	[Header("Rect Transform Properties")]
	[SerializeField]
	private float _spacing;

	[SerializeField]
	private float _paddingTop;

	[SerializeField]
	private float _paddingBot;

	public void AddToObserveList(List<RectTransform> list)
	{
	}

	public void UpdateSize()
	{
	}
}
