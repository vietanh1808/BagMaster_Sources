using UnityEngine;

namespace Game.EquipmentSystem
{
	[CreateAssetMenu(fileName = "EquipmentInfoVisualData", menuName = "Equipment/EquipmentInfoVisualData", order = 0)]
	public class EquipmentInfoVisualData : ScriptableObject
	{
		[field: SerializeField]
		public Sprite BackgroundSprite { get; private set; }

		[field: SerializeField]
		public Sprite RarityLevelFrameSprite { get; private set; }

		[field: SerializeField]
		public Sprite PartBackgroundSprite { get; private set; }
	}
}
