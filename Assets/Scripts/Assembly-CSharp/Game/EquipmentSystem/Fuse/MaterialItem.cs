using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Fuse
{
	public class MaterialItem : ResultItem
	{
		[SerializeField]
		private FusePanel fuseTab;

		[SerializeField]
		private Image _allRarityItemImg;

		[SerializeField]
		private List<GameObject> _itemTypeObjs;

		[SerializeField]
		private GameObject _allRarityItemObj;

		[SerializeField]
		private GameObject _shadow;

		public void Pop()
		{
		}

		public void SwitchType(MaterialType newType)
		{
		}

		public void SetAllRarityItemSprite(Sprite sprite)
		{
		}
	}
}
