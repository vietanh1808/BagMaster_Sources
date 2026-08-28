using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "FloatGearRecoilProfile", menuName = "GearAnimation/FloatGearRecoilProfile", order = 0)]
	public class FloatGearRecoilProfile : ScriptableObject
	{
		public float RecoilDistance;

		public float RecoilDuration;
	}
}
