using System;
using Game.EquipmentSystem;
using UnityEngine.UI;

namespace Shop.Gacha.Views
{
	[Serializable]
	public class PreviewSlot
	{
		public EquipmentPart Part;

		public Image Icon;

		public Button PreviewButton;
	}
}
