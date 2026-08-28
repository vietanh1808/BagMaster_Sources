using System;
using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "ElementalSpriteData", menuName = "Game/ElementalSpriteData")]
	public class ElementalSpriteData : ScriptableObject
	{
		[Serializable]
		private class ElementalData
		{
			public Elemental Elemental;

			public Sprite[] Sprites;
		}

		[SerializeField]
		private List<ElementalData> _elementalDatas;

		public Sprite GetSprite(Elemental elemental, int level)
		{
			return null;
		}
	}
}
