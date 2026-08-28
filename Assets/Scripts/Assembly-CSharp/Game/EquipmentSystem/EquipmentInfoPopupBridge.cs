using Game.EquipmentSystem.Inventory;
using UnityEngine;

namespace Game.EquipmentSystem
{
	public class EquipmentInfoPopupBridge : EquipmentInfo
	{
		[SerializeField]
		private Transform _contentContainer;

		[SerializeField]
		private InfoPopup _detailsContentPrefab;

		[SerializeField]
		private InfoPopup _nonDetailsContentPrefab;

		private InfoPopup _currentInstance;

		private InfoPopup _instantiatedFromPrefab;

		protected override void UpdateInfo()
		{
		}
	}
}
