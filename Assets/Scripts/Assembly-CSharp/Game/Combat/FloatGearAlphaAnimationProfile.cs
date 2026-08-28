using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "FloatGearAlphaAnimationProfile", menuName = "GearAnimation/FloatGearAlphaAnimationProfile", order = 0)]
	public class FloatGearAlphaAnimationProfile : ScriptableObject
	{
		[field: SerializeField]
		public float FadeDuration { get; private set; }

		[field: SerializeField]
		public float Alpha { get; private set; }
	}
}
