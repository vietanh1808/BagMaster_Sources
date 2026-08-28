using DG.Tweening;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "GearSynercyEffectProfile", menuName = "Game/GearSynercyEffectProfile", order = 0)]
	public class GearSynercyEffectProfile : ScriptableObject
	{
		[field: Header("Buff Others")]
		[field: SerializeField]
		public float InitialDelay { get; private set; }

		[field: SerializeField]
		public GameObject ThrownVfx { get; private set; }

		[field: SerializeField]
		public GameObject ThrownHitVfx { get; private set; }

		[field: SerializeField]
		public GameObject ThrownRemainVfx { get; private set; }

		[field: SerializeField]
		public float ThrowingMovementDuration { get; private set; }

		[field: SerializeField]
		public Ease ThrowingMovementEase { get; private set; }

		[field: SerializeField]
		public float ThrowingDuration { get; private set; }

		[field: Header("Buff Self")]
		[field: SerializeField]
		public GameObject SelfSynergyVfx { get; private set; }

		[field: SerializeField]
		public GameObject SelfSynergyHitVfx { get; private set; }

		[field: SerializeField]
		public float DelayBeforeSelfSynergy { get; private set; }

		[field: SerializeField]
		public float SelfSynergyMovementDuration { get; private set; }

		[field: SerializeField]
		public Ease SelfSynergyMovementEase { get; private set; }

		[field: SerializeField]
		public float SelfSynergyDuration { get; private set; }
	}
}
