using System.Collections.Generic;
using UnityEngine;

namespace Game.EquipmentSystem.Heroes
{
	public class HeroSpecialUpgradePanel : EquipmentInfo
	{
		[Header("LayoutGroup")]
		[SerializeField]
		private RectTransform itemContainer;

		[SerializeField]
		private List<GameObject> items;

		[SerializeField]
		private RectTransform line;

		[SerializeField]
		private float paddingTop;

		[SerializeField]
		private float paddingBottom;

		[SerializeField]
		private float spacing;

		[Header("Refs")]
		[SerializeField]
		private SpecialUpgradeInfoPopup upgradeInfoPopup;

		private RectTransform _currentUpgradeUI;

		private SpecialUpgradeData _specialUpgradeData;

		private int _currentIndex;

		private OwnedItemEntity _hero;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void ListenUpgrade(OwnedResourceEntity resource, int changedAmout)
		{
		}

		protected override void UpdateInfo()
		{
		}

		public void OpenUpgradePopup()
		{
		}
	}
}
