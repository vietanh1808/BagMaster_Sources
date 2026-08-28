using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Heroes
{
	public class HeroUpgradePanel : EquipmentInfo
	{
		[Header("LayoutGroup")]
		[SerializeField]
		private RectTransform itemContainer;

		[SerializeField]
		private StatModifierInfoUI itemPrefab;

		[SerializeField]
		private RectTransform line;

		[SerializeField]
		private RectTransform progressLock;

		[SerializeField]
		private float paddingTop;

		[SerializeField]
		private float paddingBottom;

		[SerializeField]
		private float spacing;

		[Header("UI")]
		[SerializeField]
		private Image heroIcon;

		[SerializeField]
		private TextMeshProUGUI heroNameTxt;

		[SerializeField]
		private TextMeshProUGUI heroLevelTxt;

		[SerializeField]
		private string heroLevelStrFormat;

		[SerializeField]
		private StatModifierGroupUI statModifierGroupUI;

		[Header("Refs")]
		[SerializeField]
		private UpgradeInfoPopup upgradeInfoPopup;

		private List<StatModifierInfoUI> _cachedUpgradeUI;

		private RectTransform _currentUpgradeUI;

		private List<EquipmentLevelData> _allLevelDatas;

		private EquipmentLevelData _currentLevelData;

		private EquipmentLevelData _nextLevelData;

		private int _currentIndex;

		private OwnedItemEntity _hero;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEquipmentLevelChanged(int levelId, int newLevel)
		{
		}

		protected override void UpdateInfo()
		{
		}

		private void OpenUpgradePopup()
		{
		}
	}
}
