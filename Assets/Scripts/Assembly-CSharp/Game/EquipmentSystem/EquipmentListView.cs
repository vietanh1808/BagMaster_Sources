using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Game.EquipmentSystem
{
	public class EquipmentListView : MonoBehaviour
	{
		public class DisplayData
		{
			public EquipmentData EquipmentData;

			public OwnedItemEntity OwnedItem;
		}

		[SerializeField]
		private List<EquipmentInfo> _itemViews;

		[SerializeField]
		private bool _autoUpdateUI;

		[SerializeField]
		private CustomGridLayout _gridLayout;

		[SerializeField]
		private int _unloadMinium;

		[Header("Events")]
		public UnityEvent OnPostUpdateEvent;

		private List<DisplayData> _displayDatas;

		private List<EquipmentInfo> _activeItemViews;

		private Predicate<OwnedItemEntity> _validationMethod;

		private Comparison<DisplayData> _sortMethod;

		private Predicate<DisplayData> _filterMethod;

		private bool _dirtyOrder;

		public IEnumerable<EquipmentInfo> ItemViews => null;

		private void LateUpdate()
		{
		}

		public void SetValidationMethod(Predicate<OwnedItemEntity> validationMethod)
		{
		}

		public void SetSortMethod(Comparison<DisplayData> sortMethod)
		{
		}

		public void SetFilterMethod(Predicate<DisplayData> filterMethod)
		{
		}

		public IReadOnlyList<EquipmentInfo> GetAllItemViews()
		{
			return null;
		}

		public void LoadDisplayDatas(IReadOnlyCollection<OwnedItemEntity> items)
		{
		}

		public void AddDisplayData(OwnedItemEntity ownedItem)
		{
		}

		public void RemoveDisplayData(OwnedItemEntity ownedItem)
		{
		}

		public void ClearDisplayDatas()
		{
		}

		public void SetDirty()
		{
		}

		public void UpdateUI()
		{
		}

		private void SortDisplayDatas()
		{
		}

		private void UpdateItemOrder()
		{
		}

		public void Unload()
		{
		}

		public void AnimateRefresh()
		{
		}
	}
}
