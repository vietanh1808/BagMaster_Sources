using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class UpgradeInfoPopup : MonoBehaviour
	{
		[Header("UI")]
		[SerializeField]
		private RectTransform popup;

		[SerializeField]
		private Vector2 popupAnchorOffset;

		[SerializeField]
		private GameObject statChangeTemplate;

		[SerializeField]
		private GameObject costItemTemplate;

		[SerializeField]
		private float spacingBetweenRequireCostAndStatChange;

		[SerializeField]
		private float bottomPadding;

		[SerializeField]
		private float topPadding;

		[SerializeField]
		private Button upgradeBtn;

		[SerializeField]
		private Button closeBtn;

		private EquipmentData _equipmentData;

		private EquipmentLevelData _current;

		private Transform _initialAnchorUIParent;

		private Transform _anchorUI;

		private List<GameObject> _statItemCache;

		private List<GameObject> _costItemCache;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Open(RectTransform anchorUI, EquipmentData equipmentData, EquipmentLevelData current, EquipmentLevelData next)
		{
		}

		public void Close()
		{
		}

		private void ShowStatChanges(EquipmentLevelData current, EquipmentLevelData next)
		{
		}

		private void ShowRequireResources(EquipmentLevelData levelData)
		{
		}

		private GameObject GetOrAdd(List<GameObject> source, int index, GameObject template)
		{
			return null;
		}

		private void UpdatePopupSize(int statModCount, int requireResCount)
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
