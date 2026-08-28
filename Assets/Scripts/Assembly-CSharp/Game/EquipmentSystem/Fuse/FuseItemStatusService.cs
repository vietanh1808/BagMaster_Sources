using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace Game.EquipmentSystem.Fuse
{
	public class FuseItemStatusService : IDisposable
	{
		private readonly EquipmentListViewV2<Item> _equipmentListView;

		private readonly FuseMap _fuseMap;

		private readonly Transform _shadow;

		private readonly HashSet<OwnedItemEntity> _selectedAsMaterialItems;

		private EquipmentData _highlightedEquipment;

		private OwnedItemEntity _highlightedItemEntity;

		private bool _needRefresh;

		private bool _hasAllRequiredMaterial;

		private bool IsInFuseMode => false;

		public FuseItemStatusService(EquipmentListViewV2<Item> equipmentListView, FuseMap fuseMap, Transform shadow)
		{
		}

		private void OnItemBecomeVisible(EquipmentDisplayData data, Item viewItem)
		{
		}

		public void HighlightFuseableItem(EquipmentData equipmentData, OwnedItemEntity ownedItem)
		{
		}

		public void Update()
		{
		}

		private void HighlightIfSelected(Item itemView)
		{
		}

		private void HighlightIfFusable(Item itemView, IReadOnlyList<OwnedItemEntity> fusableItems)
		{
		}

		private bool IsSelectedAsMaterial(Item item)
		{
			return false;
		}

		private static void Highlight(Item item)
		{
		}

		private bool ShouldShowNotification(EquipmentData data)
		{
			return false;
		}

		public void ClearEffects()
		{
		}

		public void SetEnoughMaterial(ReadOnlyCollection<OwnedItemEntity> materials)
		{
		}

		public void SetItemPushed(int index, OwnedItemEntity material)
		{
		}

		public void SetItemPopped(int index, OwnedItemEntity material)
		{
		}

		private Item FindViewByOwnedItem(OwnedItemEntity ownedItem)
		{
			return null;
		}

		private void ShowShadow()
		{
		}

		private void HideShadow()
		{
		}

		public void Dispose()
		{
		}
	}
}
