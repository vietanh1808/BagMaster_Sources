using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(fileName = "SynercyPhaseData", menuName = "Game/SynercyPhaseData", order = 0)]
	public class SynercyPhaseData : ScriptableObject
	{
		[SerializeField]
		public AnimationCurve DelayBetweenBuffedCurve;

		[field: SerializeField]
		public AudioClip SynercySound { get; private set; }

		[field: Space(5f)]
		[field: SerializeField]
		public float SupportGearAlpha { get; private set; }

		[field: Space(5f)]
		[field: SerializeField]
		public float DelayBetweenBuffed { get; private set; }

		[field: SerializeField]
		public AnimationCurve DelayBetweenGearCurve { get; private set; }

		[field: Space(5f)]
		[field: SerializeField]
		public float DelayBetweenGears { get; private set; }

		[field: Space(5f)]
		[field: SerializeField]
		public float CpTextAlphaReduce { get; private set; }

		[field: SerializeField]
		public float CpTextMinAlphaAlpha { get; private set; }

		[field: SerializeField]
		public float CpTextScaleIncrease { get; private set; }
	}
}
