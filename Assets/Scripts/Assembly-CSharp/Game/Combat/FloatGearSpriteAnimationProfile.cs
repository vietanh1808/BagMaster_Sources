using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "FloatGearSpriteAnimationProfile", menuName = "GearAnimation/FloatGearSpriteAnimationProfile", order = 0)]
	public class FloatGearSpriteAnimationProfile : ScriptableObject
	{
		[SerializeField]
		private Sprite[] _multiplierSprites;

		[field: SerializeField]
		public Sprite BaseSprite { get; private set; }

		[field: SerializeField]
		public int FrameRate { get; private set; }

		[field: SerializeField]
		public bool Loop { get; private set; }

		public Sprite[] MultiplierSprites => null;
	}
}
