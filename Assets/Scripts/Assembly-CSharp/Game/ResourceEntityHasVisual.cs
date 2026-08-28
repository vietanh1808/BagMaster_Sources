using System;
using Game.Constant;
using UnityEngine;

namespace Game
{
	public abstract class ResourceEntityHasVisual : ResourceEntity
	{
		public string NameKey;

		public string DescKey;

		public string IconName;

		public Rarity Rarity;

		public bool DisplayOwned;

		[Obsolete("Use SpriteAddressableExtensions.SetSprite()")]
		public Sprite Icon => null;

		public string LocalizedName => null;

		public string LocalizedDescription => null;

		public ResourceEntityHasVisual(int id)
			: base(0)
		{
		}
	}
}
