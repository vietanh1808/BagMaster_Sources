using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "FloatGearThrustProfile", menuName = "GearAnimation/FloatGearThrustProfile", order = 0)]
	public class FloatGearThrustProfile : ScriptableObject
	{
		[field: SerializeField]
		public float TimeScale { get; private set; }

		[field: Header("Recoild")]
		[field: SerializeField]
		public float Recoil { get; private set; }

		[field: SerializeField]
		public float RecoilDuration { get; private set; }

		[field: SerializeField]
		public Ease RecoilEase { get; private set; }

		[field: Header("Attack")]
		[field: SerializeField]
		public float MinDistanceByRange { get; private set; }

		[field: SerializeField]
		public float DelayAttack { get; private set; }

		[field: SerializeField]
		public float AttackDuration { get; private set; }

		[field: SerializeField]
		public Ease AttackEase { get; private set; }

		[field: SerializeField]
		public float HitFrameDuration { get; private set; }

		[field: Header("Back")]
		[field: SerializeField]
		public float BackDuration { get; private set; }

		[field: SerializeField]
		public Ease BackEase { get; private set; }
	}
}
