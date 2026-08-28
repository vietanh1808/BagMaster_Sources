using System;
using Game;
using UnityEngine;
using UnityEngine.EventSystems;

[Obsolete]
public class ItemDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	private Transform originalParent;

	private CanvasGroup canvasGroup;

	public OwnedItemEntity _ownedItem;

	private GearItemUI _gearItemUI;

	private PlayerInfo PInfo => null;

	private void Start()
	{
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	public void OnDrag(PointerEventData eventData)
	{
	}

	public void OnEndDrag(PointerEventData eventData)
	{
	}

	public void Equip()
	{
	}

	public void Unequip()
	{
	}

	private bool CanEquip()
	{
		return false;
	}
}
