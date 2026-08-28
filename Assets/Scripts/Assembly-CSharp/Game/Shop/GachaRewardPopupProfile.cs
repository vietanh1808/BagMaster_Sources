using UnityEngine;

namespace Game.Shop
{
	[CreateAssetMenu(fileName = "GachaRewardPopupProfile", menuName = "Game/GachaRewardPopupProfile", order = 0)]
	public class GachaRewardPopupProfile : ScriptableObject
	{
		[field: SerializeField]
		public Sprite ChestSprite { get; private set; }

		[field: SerializeField]
		public Sprite ChestSpriteOpen { get; private set; }

		[field: SerializeField]
		public Sprite ChestSpriteOpenFake { get; private set; }

		[field: SerializeField]
		public Sprite BackgroundSprite { get; private set; }

		[field: SerializeField]
		public Sprite BackgroundDecoSprite { get; private set; }

		[field: SerializeField]
		public Material BackgroundMaterial { get; private set; }
	}
}
