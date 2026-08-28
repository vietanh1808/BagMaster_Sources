using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "FloatGearSlashingProfile", menuName = "GearAnimation/FloatGearSlashingProfile", order = 0)]
	public class FloatGearSlashingProfile : ScriptableObject
	{
		[field: SerializeField]
		public float TimeScale { get; private set; }

		[field: Header("Recoil")]
		[field: SerializeField]
		public int RecoilAngle { get; private set; }

		[field: SerializeField]
		public Vector2 RecoilAnglerRange { get; private set; }

		[field: SerializeField]
		public float RecoilAngleDuration { get; private set; }

		[field: SerializeField]
		public float ToSwingPositionDuration { get; private set; }

		[field: Header("Slash Radius")]
		[field: SerializeField]
		public float MinDistanceByRange { get; private set; }

		[field: SerializeField]
		public float SlashStartDelay { get; private set; }

		[field: SerializeField]
		public AnimationCurve SlashXTween { get; private set; }

		[field: SerializeField]
		public Ease SlashYEase { get; private set; }

		[field: SerializeField]
		public Ease SlashRotationEase { get; private set; }

		[field: SerializeField]
		public float SlashDuration { get; private set; }

		[field: SerializeField]
		public int EndSlashAngle { get; private set; }

		[field: SerializeField]
		public float SlashEndDelay { get; private set; }

		[field: Header("Duration")]
		[field: SerializeField]
		public float BackDuration { get; private set; }
	}
}
