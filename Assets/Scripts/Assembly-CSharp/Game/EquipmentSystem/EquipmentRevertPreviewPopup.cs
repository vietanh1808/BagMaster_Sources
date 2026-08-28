using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem
{
	public class EquipmentRevertPreviewPopup : MonoBehaviour
	{
		[SerializeField]
		private EquipmentInfo _sourceItemUI;

		[SerializeField]
		private List<ResourceView> _yieldItems;

		[SerializeField]
		private Button _confirmBtn;

		[SerializeField]
		private Button _cancelBtn;

		private EquipmentData _data;

		private OwnedItemEntity _owned;

		private bool _confirmed;

		public Action<bool> OnClosedEvent;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo(EquipmentData data, OwnedItemEntity owned)
		{
		}

		private void BuildYieldViews(EquipmentData data)
		{
		}

		private void OnConfirm()
		{
		}

		private void OnCancel()
		{
		}

		private void Close()
		{
		}
	}
}
