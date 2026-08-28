using System.Collections.Generic;
using Game.EquipmentSystem;
using Game.Shop;
using UnityEngine;

namespace Shop.Gacha.Views
{
	public class GachaPreviewEquipmentsView : MonoBehaviour
	{
		[SerializeField]
		private PreviewSlot[] _slots;

		public void UpdateSlots(GachaData gachaData)
		{
		}

		private void OpenEquipmentInfoPopup(EquipmentData equipmentData)
		{
		}

		private Dictionary<EquipmentPart, EquipmentData> GetFeaturedEquipment(GachaData gachaData)
		{
			return null;
		}
	}
}
