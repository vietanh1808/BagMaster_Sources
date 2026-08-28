using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class SpecialUpgradeInfoPopup : MonoBehaviour
	{
		[Header("UI")]
		[SerializeField]
		private RectTransform popup;

		[SerializeField]
		private Vector2 popupAnchorOffset;

		[SerializeField]
		private List<GameObject> costItems;

		[SerializeField]
		private float descSize;

		[SerializeField]
		private float bottomPadding;

		[SerializeField]
		private float topPadding;

		[SerializeField]
		private Button upgradeBtn;

		[SerializeField]
		private Button closeBtn;

		private SpecialUpgradeData _upgradeData;

		private Transform _initialAnchorUIParent;

		private Transform _anchorUI;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Open(RectTransform anchorUI, SpecialUpgradeData upgradeData)
		{
		}

		public void Close()
		{
		}

		private void ShowDescription(SpecialUpgradeData data)
		{
		}

		private void ShowRequireResources(List<ResourceRequireData> resourceRequires)
		{
		}

		private void UpdatePopupSize(int requireResCount)
		{
		}

		private void Upgrade()
		{
		}

		[ContextMenu("Test AutoSize")]
		private void TestAutoSize()
		{
		}
	}
}
