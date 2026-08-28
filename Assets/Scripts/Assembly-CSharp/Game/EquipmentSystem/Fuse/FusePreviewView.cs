using System.Collections.Generic;
using Game.Constant;
using UnityEngine;

namespace Game.EquipmentSystem.Fuse
{
	public class FusePreviewView : MonoBehaviour
	{
		[Header("Preview Items")]
		[SerializeField]
		private MaterialItem[] _previewItems;

		[Header("Preview Material Sprites")]
		[SerializeField]
		private List<Sprite> _armorRaritySprites;

		[SerializeField]
		private List<Sprite> _weaponRaritySprites;

		[SerializeField]
		private List<Sprite> _accessoryRaritySprites;

		[SerializeField]
		private List<Sprite> _headRaritySprites;

		public void ShowPreview(EquipmentData equipmentData, int materialCount)
		{
		}

		public void Clear()
		{
		}

		private Sprite GetVaryItemSprite(Rarity rarity, EquipmentPart part)
		{
			return null;
		}
	}
}
