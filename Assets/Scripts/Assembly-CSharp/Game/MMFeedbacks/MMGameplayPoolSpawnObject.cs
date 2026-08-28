using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.MMFeedbacks
{
	[ExecuteAlways]
	[AddComponentMenu(null)]
	[FeedbackPath("Custom/MMGameplayPoolSpawnObject")]
	public class MMGameplayPoolSpawnObject : MMF_Feedback
	{
		public enum PositionModes
		{
			FeedbackPosition = 0,
			WorldPosition = 1,
			Script = 2
		}

		[MMFInspectorGroup("Spawning", true, 57, false, false)]
		public GameObject Prefab;

		public PositionModes PositionMode;

		public Vector3 PositionOffset;

		protected override void CustomPlayFeedback(Vector3 position, float feedbacksIntensity = 1f)
		{
		}

		protected virtual Vector3 GetPosition(Vector3 position)
		{
			return default;
		}
	}
}
