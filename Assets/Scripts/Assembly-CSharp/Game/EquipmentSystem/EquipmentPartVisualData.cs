using UnityEngine;

namespace Game.EquipmentSystem
{
	[CreateAssetMenu(fileName = "EquipmentPartVisualData", menuName = "Equipment/EquipmentPartVisualData", order = 0)]
	public class EquipmentPartVisualData : ScriptableObject
	{
		[Header("Icons")]
		[SerializeField]
		private Sprite _headIcon;

		[SerializeField]
		private Sprite _bodyIcon;

		[SerializeField]
		private Sprite _weaponIcon;

		[SerializeField]
		private Sprite _accessoryIcon;

		[SerializeField]
		private Sprite _characterIcon;

		[SerializeField]
		private Sprite _defaultIcon;

		public Sprite GetPartIcon(EquipmentPart part)
		{
			return null;
		}
	}
}
